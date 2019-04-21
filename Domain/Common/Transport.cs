using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string.Format("{0, 20} {1, 10} {2, 10} {3, 10}",
                TypeOfTransport,
                MaxWeight,
                TimeOfDelivery,
                Price);
    }
}
