using Domain.Extensions;
using System;

namespace Domain.Common
{
    public class Transport : ITransport, IEquatable<ITransport>
    {
        public Transport(int iD, int price, int timeOfDelivery, string typeOfTransport, int maxWeight)
        {
            ID = iD;
            Price = price;
            TimeOfDelivery = timeOfDelivery;
            TypeOfTransport = typeOfTransport ?? throw new ArgumentNullException(nameof(typeOfTransport));
            MaxWeight = maxWeight;
        }

        public int ID { get; }
        public int Price { get; }
        public int TimeOfDelivery { get; }
        public string TypeOfTransport { get; }
        public int MaxWeight { get; }

        public bool Equals(ITransport other)
        {
            return other.ID == ID;
        }

        public override string ToString()
        {
            return TypeOfTransport;
        }

        public string Description =>
        StringExtensions.Align(
            new string[]{
                TypeOfTransport,
                MaxWeight.ToString(),
                TimeOfDelivery.ToString(),
                Price.ToString()
            },
            new int[] {
                20,
                14,
                10,
                10
            });
    }
}
