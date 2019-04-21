using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Request
{
    public class AddTransportRequest : IRequest
    {
        public AddTransportRequest(Transport transport)
        {
            Sql = $"exec CreateTransport {transport.Price}, {transport.TimeOfDelivery}, " +
                $" '{transport.TypeOfTransport}', {transport.MaxWeight}";
        }

        public string Sql { get; }
    }
}
