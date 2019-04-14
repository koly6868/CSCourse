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
                    "1"
                });
                items[i].Tag = products[i].ID;
            }
            return items;
        }

        public static ListViewItem[] Convert(ListView.ListViewItemCollection collection)
        {
            ListViewItem[] items = new ListViewItem[collection.Count];
            collection.CopyTo(items, 0);
            return items;
        }
    }
}
