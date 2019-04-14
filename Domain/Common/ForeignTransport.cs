using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class ForeignTransport : ITransport
    {
        public int ID { get; }
        public int MaxWeight { get; }
        public int Price { get; }
        public int TimeOfDelivery { get; }
        public string TypeOfTransport { get; }
    }
}
