namespace Domain.Infrastructure.Query
{
    public class GetAllTrnasportQuery : IQuery
    {
        public GetAllTrnasportQuery()
        {
            Sql = "SELECT * FROM typeOfDelivery";
        }

        public string Sql { get; }
    }
}
