using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Company : IEquatable<Company>
    {
        public int ID { get;  }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string FormOfCompany { get; set; }
        public IEnumerable<AdressOfDepartment> Adreses => adresses;

        public void AddAdress(AdressOfDepartment adress)
        {
            adresses.Add(adress);
        }

        public bool Equals(Company other)
        {
            return other.ID == ID;
        }

        private List<AdressOfDepartment> adresses = new List<AdressOfDepartment>();

        
    }
}
