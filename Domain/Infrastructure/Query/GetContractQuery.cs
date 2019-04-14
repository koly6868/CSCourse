using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetContractQuery : IQuery
    {
        public GetContractQuery(string sql)
        {
            Sql = ""; 
        }

        public string Sql { get; }
    }
}
