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
