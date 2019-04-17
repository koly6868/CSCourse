using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Product : IProduct, IEquatable<IProduct>
    {
        //public Product(int ID, string typeOfProduct, string color, float weight, int lenght, int width, int height)
        //{
        //    this.ID = ID;
        //    TypeOfProduct = typeOfProduct ?? throw new ArgumentNullException(nameof(typeOfProduct));
        //    Color = color ?? throw new ArgumentNullException(nameof(color));
        //    Weight = weight;
        //    Lenght = lenght;
        //    Width = width;
        //    Height = height;
        //}

        public static Product Create(int ID, string typeOfProduct, string color, double weight, int lenght, int width, int height)
        {
            return new Product
            {
                ID = ID,
                TypeOfProduct = typeOfProduct ?? throw new ArgumentNullException(nameof(typeOfProduct)),
                Color = color ?? throw new ArgumentNullException(nameof(color)),
                Weight = weight,
                Lenght = lenght,
                Width = width,
                Height = height
            };
        }

        public int ID { get; private set; }
        public string TypeOfProduct { get; private set; }
        public string Color { get; private set; }
        public double Weight { get; private set; }
        public int Lenght { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public bool Equals(IProduct other)
        {
            return other.ID == ID;
        }
    }
}
