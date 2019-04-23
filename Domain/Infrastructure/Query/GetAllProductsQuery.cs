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
