using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Common
{
    public class Contract : IEquatable<Contract>
    {
        public int ID { get; private set; }
        public IEnumerable<KeyValuePair<IProduct,int>> Products => products;
        public ITransport Transport { get; private set; }
        public ITransport AdditionalTransport { get; private set; }
        public int FullPrice { get; private set; }
        public DateTime Date { get; private set; }
        public Company Company { get; set; }

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

        public static ContractBuilder CreateBuilder()
        {
            return new ContractBuilder();
        }

        public class ContractBuilder
        {
            public ContractBuilder()
            {
                contract = new Contract(-1, 0, new DateTime());
            }

            public Contract Build()
            {
                return contract;
            }

            public ContractBuilder SetID(int ID)
            {
                contract.ID = ID;
                return this;
            }

            public ContractBuilder SetDate(DateTime date)
            {
                contract.Date = date;
                return this;
            }

            public ContractBuilder SetFullPrice(int price)
            {
                contract.FullPrice = price;
                return this;
            }

            public ContractBuilder SetTransport(ITransport transport)
            {
                contract.Transport = transport;
                return this;
            }

            public ContractBuilder SetAdditionalTransport(ITransport transport)
            {
                contract.AdditionalTransport = transport;
                return this;
            }

            public ContractBuilder SetProducts(KeyValuePair<IProduct, int>[] products)
            {
                //reset list
                contract.products = new Dictionary<IProduct, int>();
                //add new elements
                foreach(KeyValuePair<IProduct, int> item in products)
                {
                    contract.AddProduct(item.Key, item.Value);
                }
                return this;
            }

            public ContractBuilder SetCompany(Company company)
            {
                contract.Company = company;
                return this;
            }

            public IEnumerable<KeyValuePair<IProduct, int>> ShowProducts()
            {
                return contract.Products;
            }

            private Contract contract;
        }
    }
}
