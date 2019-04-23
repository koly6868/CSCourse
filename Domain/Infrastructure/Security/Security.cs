using Dapper;
using Domain.Common;
using Domain.Infrastructure.Query;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace Domain.Infrastructure.Security
{
    public class Security : ISecurity
    {
        public static Security GetInstance()
        {
            return instance;
        }

        public void Configurate(string connectionStringForm)
        {
            this.connectionStringForm = connectionStringForm;
        }

        public string GetConnectionString()
        {
            return connectionString;
        }

        public IResult<int> Authenticate(string login, string password)
        {
            int roleId = 0;
            connectionString = connectionStringForm
                .Replace("{login}", login)
                .Replace("{password}", password);

            try
            {
                IQuery query = new GetRoleQuery(login);
                using ( var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    roleId = connection.Query<int>(query.Sql).First();
                }
                return Result<int>.Success(roleId);
            }catch(Exception e)
            {
                return Result<int>.Failure(e);
            }
        }
        private string connectionStringForm;
        private string connectionString;
        private static Security instance = new Security();
        private Security() { }
    }
}
