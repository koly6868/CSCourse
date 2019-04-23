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
