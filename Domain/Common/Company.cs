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

        public void AddAdress(IEnumerable<AdressOfDepartment> adresses)
        {
            foreach(AdressOfDepartment adress in adresses)
            {
                this.adresses.Add(adress);
            }
        }

        public bool Equals(Company other)
        {
            return other.ID == ID;
        }

        public override string ToString()
        {
            return Name;
        }

        private List<AdressOfDepartment> adresses;

        public Company(int id, string name, int rating, string formOfCompany)
        {
            ID = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Rating = rating;
            FormOfCompany = formOfCompany ?? throw new ArgumentNullException(nameof(formOfCompany));
            adresses = new List<AdressOfDepartment>();
        }
    }
}
