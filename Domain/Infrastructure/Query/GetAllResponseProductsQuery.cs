using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetAllResponseProductsQuery : IQuery
    {
        public GetAllResponseProductsQuery()
        {
            Sql = "SELECT BuyContract.ID, TabelOfReqRes.ID_delivery, " +
                    "TabelOfReqRes.IsOk, TabelOfReqRes.reason FROM TabelOfReqRes "+
                    "JOIN Delivery ON Delivery.ID = TabelOfReqRes.ID_delivery "+
                    "JOIN BuyContract ON BuyContract.ID_delivery = Delivery.ID";
        }

        public string Sql { get; }

    }
}
