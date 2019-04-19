using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Infrastructure.Query;
using Dapper;

namespace Domain.Infrastructure
{
    public class TransportRepository : IRepository<Transport>
    {
        private TransportRepository() { }

        public bool Delite(int ID)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool Update(Transport el)
        {
            throw new NotImplementedException();
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
