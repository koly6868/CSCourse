namespace Domain.Infrastructure.Request
{
    public class DeleteTransportRequest : IRequest
    {
        public DeleteTransportRequest()
        {
            Sql = "DELETE FROM typeOfDelivery WHERE typeOfDelivery.ID = @ID";
        }

        public string Sql { get; }
    }
}
