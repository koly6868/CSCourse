using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    public class GetTransportByIDQuery : IQuery
    {
        public GetTransportByIDQuery()
        {
            Sql = "SELECT * FROM typeOfDelivery " +
                    "WHERE typeOfDelivery.ID = @ID";
        }

        public string Sql { get; }
    }
}
