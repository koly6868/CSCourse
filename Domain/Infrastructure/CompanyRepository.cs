using Dapper;
using Domain.Common;
using Domain.Infrastructure.Query;
using Domain.Infrastructure.Request;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Domain.Infrastructure
{
    public class CompanyRepository : IRepository<Company>
    { 
        public Company Get(int ID)
        {
            IQuery query = new GetCompanyQuery();
            Company res = null;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    //reducing into one object
                    connection.Query<Company, AdressOfDepartment, Company>(
                        query.Sql,
                        (company, adress) =>
                        {
                            if (res == null)
                            {
                                res = company;
                            }
                            res.AddAdress(adress);
                            
                            return company;
                        },
                        splitOn: "ID", 
                        param : new { ID })
                        .First();
                }
            } catch(Exception e)
            {
                return null;
            }

            return res;
        }

        public bool Update(Company el)
        {
            IRequest request = new UpdateCompanyRequest(el);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        connection.Execute(request.Sql, transaction : transaction);
                        transaction.Commit();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Add(Company el)
        {
            IRequest request = new AddCompanyRequestcs(el);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        connection.Execute(request.Sql, transaction: transaction);
                        transaction.Commit();
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public IEnumerable<Company> GetAll()
        {
            IQuery query = new GetAllCompanyQuery();
            List<Company> res = new List<Company>();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    //reducing into one object
                    connection.Query<Company, AdressOfDepartment, Company>(
                        query.Sql,
                        (company, adress) =>
                        {
                            int index = 0;
                            if (!res.Contains(company))
                            {
                                res.Add(company);
                                index = res.Count - 1;
                            }
                            else
                            {
                                index = res.IndexOf(company);
                            }
                            
                            res[index].AddAdress(adress);

                            return company;
                        },
                        splitOn: "ID");
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return res;
        }

        public bool Delete(int ID)
        {
            IRequest request = new DeleteCompanyRequest();

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    connection.Execute(request.Sql, new { ID });
                }
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        public static CompanyRepository GetInstance()
        {
            return repository;
        }

        private static CompanyRepository repository = new CompanyRepository();
        private string connectionString;
    }
}
