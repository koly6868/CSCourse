namespace Domain.Infrastructure.Query
{
    class GetProductsByContract : IQuery
    {
        public GetProductsByContract()
        {
            Sql = "SELECT  Product.ID, Product.typeOfProduct, Product.color, Product.weight, Product.lenght, Product.width, Product.height, ListOfProducts.count " +
                    "FROM[Purchase department].[dbo].[BuyContract] " +
                    "JOIN ListOfProducts ON ListOfProducts.ID_contract = BuyContract.ID " +
                    "JOIN Product ON Product.ID = ListOfProducts.ID_product " +
                    "WHERE BuyContract.ID = @ID";
        }

        public string Sql { get; }
    }
}
