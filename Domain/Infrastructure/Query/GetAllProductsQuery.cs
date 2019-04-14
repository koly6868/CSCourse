using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetAllProductsQuery : IQuery
    {
        public GetAllProductsQuery()
        {
            Sql = "SELECT  * FROM Product";
        }

        public string Sql { get; }
    }
}
