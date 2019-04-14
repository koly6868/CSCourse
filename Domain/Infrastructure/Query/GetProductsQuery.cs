using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetProductsQuery : IQuery
    {
        public GetProductsQuery()
        {
            Sql = "SELECT  * FROM Product WHERE Product.ID = @ID";
        }

        public string Sql { get; }
    }
}
