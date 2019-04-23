namespace Domain.Infrastructure.Request
{
    public class DeleteCompanyRequest : IRequest
    {
        public DeleteCompanyRequest()
        {
            Sql = "EXEC DeleteCompany @ID";
        }

        public string Sql { get; }
    }
}
