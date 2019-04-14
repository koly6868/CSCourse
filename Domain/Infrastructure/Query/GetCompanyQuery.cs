using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetCompanyQuery : IQuery
    {
        public GetCompanyQuery()
        {
            Sql = "SELECT * FROM Company " +
                "JOIN AdressOfDepartment ON AdressOfDepartment.ID_company = Company.ID " +
                "WHERE Company.ID = @ID";
        }

        public string Sql { get; }
    }
}
