namespace Domain.Infrastructure.Request
{
    public class DeleteContractRequestcs : IRequest
    {
        public DeleteContractRequestcs()
        {
            Sql = "exec DeleteContractByID @ID";
        }

        public string Sql { get; }

    }
}
