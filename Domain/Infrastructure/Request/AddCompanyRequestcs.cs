using Domain.Common;
using System.Linq;

namespace Domain.Infrastructure.Request
{
    class AddCompanyRequestcs : IRequest
    {
        public AddCompanyRequestcs(Company company)
        {
            Sql = "INSERT INTO Company(name,rating,FormOfCompany) " +
                    $"VALUES('{company.Name}', {company.Rating}, '{company.FormOfCompany}') " +
                    GetIDRequestGenerate()+
                    AddAdressesRequestGenerate(company);
        }

        private string AddAdressesRequestGenerate(Company company)
        {
            return "INSERT INTO AdressOfDepartment(ID_company, city, street, building, phone) VALUES " +
             string.Join(", ", company.Adreses.Select(el => 
             $"(@ID, '{el.City}', '{el.Street}', {el.Building}, '{el.Phone}')"));
        }

        private string GetIDRequestGenerate()
        {
            return "DECLARE @ID INT " +
                "SET @ID = @@identity ";
        }

        public string Sql { get; }
    }
}
