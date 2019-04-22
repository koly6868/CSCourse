using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Request
{
    public class UpdateCompanyRequest : IRequest
    {
        public string Sql { get; }

        public UpdateCompanyRequest(Company company)
        {
            Sql = "UPDATE Company " +
                    $"SET name = '{company.Name}', " +
                    $"rating = {company.Rating}, " +
                    $"FormOfCompany = '{company.FormOfCompany}' " +
                    $"WHERE ID = {company.ID} " +
                    string.Join(" ", company.Adreses.Select(el => UpdateAdressRequestGenerate(el)));
        }

        private string UpdateAdressRequestGenerate(AdressOfDepartment adress)
        {
            return "UPDATE AdressOfDepartment " +
                    $"SET city = '{adress.City}', " +
                    $"street = '{adress.Street}', " +
                    $"building = {adress.Building}, " +
                    $"phone = '{adress.Phone}'" +
                    $"WHERE ID = {adress.ID} ";
        }
    }
}
