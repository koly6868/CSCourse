namespace Domain.Infrastructure.Query
{
    class GetContractQuery : IQuery
    {
        public GetContractQuery(string sql)
        {
            Sql = ""; 
        }

        public string Sql { get; }
    }
}
