using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
