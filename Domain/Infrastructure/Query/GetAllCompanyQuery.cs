using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    class GetAllCompanyQuery : IQuery
    {
        public GetAllCompanyQuery()
        {
            Sql = "SELECT Company.ID, Company.name, Company.rating, " +
                "Company.FormOfCompany, AdressOfDepartment.ID, AdressOfDepartment.city, " +
                "AdressOfDepartment.street, AdressOfDepartment.building, AdressOfDepartment.phone " +
                "FROM Company " +
                "JOIN AdressOfDepartment ON AdressOfDepartment.ID_company = Company.ID";
        }

        public string Sql { get; }
    }
}
