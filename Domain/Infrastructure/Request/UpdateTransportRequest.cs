using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Request
{
    class UpdateTransportRequest : IRequest
    {
        public UpdateTransportRequest()
        {
            Sql = "UPDATE typeOfDelivery " +
                    "SET maxWeight = @maxWeight, " +
                    "price = @price, " +
                    "timeOfDelivery = @timeOfDelivery, " +
                    "typeOfTransport = @typeOfTransport " +
                    "WHERE ID = @ID";
        }

        public string Sql { get; }
    }
}
