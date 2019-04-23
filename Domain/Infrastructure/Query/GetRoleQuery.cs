namespace Domain.Infrastructure.Query
{
    public class GetRoleQuery : IQuery
    {
        public GetRoleQuery(string login)
        {
            Sql = $"use [Purchase department] SELECT * FROM GetRole('{login}')";
            
        }

        public string Sql { get; }
    }
}
