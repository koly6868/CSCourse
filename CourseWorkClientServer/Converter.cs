using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkClientServer
{
    public static class Converter
    {
        public static ListViewItem[] Convert(Contract[] contracts)
        {
            ListViewItem[] items = new ListViewItem[contracts.Length];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new ListViewItem(new string[]{
                    contracts[i].ID.ToString(),
                    contracts[i].FullPrice.ToString(),
                    contracts[i].Date.Date.ToShortDateString(),
                    contracts[i].Transport.ToString()
                });
                items[i].Tag = contracts[i].ID;
            }
            return items;
        }

        public static ListViewItem[] Convert(Product[] products)
        {
            ListViewItem[] items = new ListViewItem[products.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ListViewItem(new string[]{
                    products[i].TypeOfProduct,
                    products[i].Color,
                    products[i].Weight.ToString(),
                    $"{products[i].Lenght}x{products[i].Width}x{products[i].Height}",
                    "1",
                    products[i].Price.ToString()
                });
                items[i].Tag = products[i].ID;
            }
            return items;
        }

        public static ListViewItem[] Convert(KeyValuePair<Product,int>[] products)
        {
            ListViewItem[] items = new ListViewItem[products.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ListViewItem(new string[]{
                    products[i].Key.TypeOfProduct,
                    products[i].Key.Color,
                    products[i].Key.Weight.ToString(),
                    $"{products[i].Key.Lenght}x{products[i].Key.Width}x{products[i].Key.Height}",
                    products[i].Value.ToString(),
                    products[i].Key.Price.ToString()
                });
                items[i].Tag = products[i].Key.ID;
            }
            return items;
        }

        public static ListViewItem[] Convert(ListView.ListViewItemCollection collection)
        {
            ListViewItem[] items = new ListViewItem[collection.Count];
            collection.CopyTo(items, 0);
            return items;
        }

        public static KeyValuePair<IProduct,int>[] ToProducts(ListView.ListViewItemCollection collection)
        {
            List<KeyValuePair<IProduct, int>> products = new List<KeyValuePair<IProduct, int>>(collection.Count);

            foreach (ListViewItem el in collection)
            {
                List<string> qualities = new List<string>(el.SubItems.Count);
                foreach (ListViewItem.ListViewSubItem item in el.SubItems)
                {
                    qualities.Add(item.Text);
                }

                int[] size;
                size = qualities[3].Split('x')
                    .Select(it => int.Parse(it)).ToArray();

                products.Add(new KeyValuePair<IProduct, int>(
                    Product.Create(
                    (int)el.Tag,
                    qualities[0],
                    qualities[1],
                    double.Parse(qualities[2]),
                    size[0],
                    size[1],
                    size[2],
                    int.Parse(qualities[5])
                    ),
                    int.Parse(qualities[4])));
            }
            return products.ToArray();
        }

        public static ListViewItem[] Convert(ITransport[] transport)
        {
            ListViewItem[] items = new ListViewItem[transport.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ListViewItem(new string[]{
                    transport[i].TypeOfTransport,
                    transport[i].MaxWeight.ToString(),
                    transport[i].TimeOfDelivery.ToString(),
                    transport[i].MaxWeight.ToString(),
                    transport[i].Price.ToString()
                });
                items[i].Tag = transport[i].ID;
            }
            return items;
        }
    }
}
