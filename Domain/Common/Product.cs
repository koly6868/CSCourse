using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Product : IProduct, IEquatable<IProduct>
    {
        public int ID { get; }
        public string TypeOfProduct { get; }
        public string Color { get; }
        public int Weight { get; }
        public int Lenght { get; }
        public int Width { get; }
        public int Height { get; }

        public bool Equals(IProduct other)
        {
            return other.ID == ID;
        }
    }
}
