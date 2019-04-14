using Domain.Common;

namespace Domain.Infrastructure.Security
{
    public interface ISecurity
    {
        IResult<int> Authenticate(string login, string password);
        void Configurate(string connectionStringForm);
        string GetConnectionString();
    }
}