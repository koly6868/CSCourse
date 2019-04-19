using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Infrastructure.Query
{
    public class GetAllTrnasportQuery : IQuery
    {
        public GetAllTrnasportQuery()
        {
            Sql = "SELECT * FROM typeOfDelivery";
        }

        public string Sql { get; }
    }
}
