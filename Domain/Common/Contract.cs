using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public class Contract : IEquatable<Contract>
    {
        public int ID { get; }
        public IEnumerable<KeyValuePair<IProduct,int>> Products => products;
        public ITransport Transport { get; private set; }
        public ITransport AdditionalTransport { get; private set; }
        public int FullPrice { get; private set; }
        public DateTimeOffset Date { get; }
        //public DateTimeOffset DateOfImplementation { get; private set; }

        public bool ChangeTransport(ITransport transport)
        {
            Transport = transport;
            return true;
        }

        public bool AddProduct(IProduct product)
        {
            if (products.Keys.Contains(product))
            {
                products[product]++;
            }
            else
            {
                products[product] = 1;
            }
            return true;
        }

        public bool AddProduct(IProduct product, int count)
        {
            if (products.Keys.Contains(product))
            {
                products[product]+= count;
            }
            else
            {
                products[product] = count;
            }
            return true;
        }

        public bool SetAdditionalTransport(ITransport transport)
        {
            AdditionalTransport = transport;
            return true;
        }

        public bool SetTransport(ITransport transport)
        {
            Transport = transport;
            return true;
        }

        public bool Equals(Contract other)
        {
            return ID == other.ID;
        }

        private Dictionary<IProduct,int> products;

        public Contract(int iD, int fullPrice, DateTime date)
        {
            ID = iD;
            FullPrice = fullPrice;
            Date = date;
            products = new Dictionary<IProduct, int>();
        }
    }
}
