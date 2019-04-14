using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    public class GetRoleQuery : IQuery
    {
        public GetRoleQuery(string login)
        {
            Sql = $"SELECT * FROM GetRole('{login}')";
            
        }

        public string Sql { get; }
    }
}
