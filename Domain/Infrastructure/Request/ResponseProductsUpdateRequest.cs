namespace Domain.Infrastructure.Request
{
    class ResponseProductsUpdateRequest : IRequest
    {
        public ResponseProductsUpdateRequest()
        {
            Sql = "exec ReturnProducts @IDContract, @Reason";
        }

        public string Sql { get; }
    }
}
