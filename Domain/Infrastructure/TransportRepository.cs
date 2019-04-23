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
    public class TransportRepository : IRepository<Transport>
    {
        private TransportRepository() { }

        public bool Delete(int ID)
        {
            IRequest request = new DeleteTransportRequest();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Execute(request.Sql, new { ID });
                    return true;
                }
            }catch (Exception e)
            {
                return false;
            }
        }

        public Transport Get(int ID)
        {
            IQuery query = new GetTransportByIDQuery();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<Transport>(query.Sql, new { ID }).First();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public IEnumerable<Transport> GetAll()
        {
            IQuery query = new GetAllTrnasportQuery();

            try
            {
                using(var connection = new SqlConnection(connectionString))
                {
                    return connection.Query<Transport>(query.Sql);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Add(Transport el)
        {
            IRequest request = new AddTransportRequest(el);

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Execute(request.Sql);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(Transport el)
        {
            IRequest request = new UpdateTransportRequest();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Execute(request.Sql, el);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static TransportRepository GetInstance()
        {
            return repository;
        }

        public static void Configure(string connectionString)
        {
            repository.connectionString = connectionString;
        }

        private string connectionString;
        private static TransportRepository repository = new TransportRepository();
    }
}
