using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Transport : ITransport, IEquatable<ITransport>
    {
        public int ID { get; }
        public int Price { get; }
        public int TimeOfDelivery { get; }
        public string TypeOfTransport { get; }
        public int MaxWeight { get; }

        public bool Equals(ITransport other)
        {
            return other.ID == ID;
        }
    }
}
