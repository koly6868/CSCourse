﻿using System;

namespace Domain.Common
{
    public class Product : IProduct, IEquatable<IProduct>
    {
        public static Product Create(int ID, string typeOfProduct, string color, double weight, int lenght, int width, int height, int Price)
        {
            return new Product
            {
                ID = ID,
                TypeOfProduct = typeOfProduct ?? throw new ArgumentNullException(nameof(typeOfProduct)),
                Color = color ?? throw new ArgumentNullException(nameof(color)),
                Weight = weight,
                Lenght = lenght,
                Width = width,
                Height = height,
                Price = Price
            };
        }

        public int ID { get; private set; }
        public string TypeOfProduct { get; private set; }
        public string Color { get; private set; }
        public double Weight { get; private set; }
        public int Lenght { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Price { get; private set; }

        public bool Equals(IProduct other)
        {
            return other.ID == ID;
        }
    }
}
