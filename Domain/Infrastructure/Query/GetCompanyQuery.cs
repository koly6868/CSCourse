namespace Domain.Infrastructure.Query
{
    class GetCompanyQuery : IQuery
    {
        public GetCompanyQuery()
        {
            Sql = "SELECT Company.ID, Company.name, Company.rating, " +
                    "Company.FormOfCompany, AdressOfDepartment.ID, AdressOfDepartment.city, " +
                    "AdressOfDepartment.street, AdressOfDepartment.building, AdressOfDepartment.phone " +
                    "FROM Company " +
                    "JOIN AdressOfDepartment ON AdressOfDepartment.ID_company = Company.ID " +
                    "WHERE Company.ID = @ID";
        }

        public string Sql { get; }
    }
}
