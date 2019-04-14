using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class AdressOfDepartment
    {
        public int ID { get; }
        public string City { get; }
        public string Street { get; set; }
        public int Building { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} {2}",City, Street, Building);
        }
    }
}
