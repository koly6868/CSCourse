using Domain.Common;

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
