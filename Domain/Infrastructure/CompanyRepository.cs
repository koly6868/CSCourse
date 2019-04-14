using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Domain.Common;
using Domain.Infrastructure.Query;

namespace Domain.Infrastructure
{
    public class CompanyRepository : IRepository<Company>
    {
        public CompanyRepository(string connectionStirng)
        {
            this.connectionStirng = connectionStirng ?? throw new ArgumentNullException(nameof(connectionStirng));
        }

        public Company Get(int ID)
        {
            IQuery query = new GetCompanyQuery();
            Company res = null;
            try
            {
                using (var connection = new SqlConnection(connectionStirng))
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
                // To do
            }

            return res;
        }

        public bool Update(Company el)
        {
            throw new NotImplementedException();
        }

        public bool Save(Company el)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            IQuery query = new GetAllCompanyQuery();
            List<Company> res = new List<Company>();
            try
            {
                using (var connection = new SqlConnection(connectionStirng))
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
                // To do
            }

            return res;
        }

        private readonly string connectionStirng;
    }
}
