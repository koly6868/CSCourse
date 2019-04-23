using System;

namespace Domain.Common
{
    public class AdressOfDepartment
    {
        public AdressOfDepartment(int id, string city, string street, int building, string phone)
        {
            ID = id;
            City = city ?? throw new ArgumentNullException(nameof(city));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            Building = building;
            Phone = phone;
        }

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
