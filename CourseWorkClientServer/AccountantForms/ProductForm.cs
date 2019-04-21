using Domain.Common;
using Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkClientServer.AccountantForms
{
    public partial class ProductForm : Form
    {
        public ProductForm(Action<KeyValuePair<IProduct, int>[]> addProducts, KeyValuePair<Product,int>[] initProducts = null)
        {
            InitializeComponent();
            productRepository = ProductRepository.GetInstance();
            LoadProducts();
            this.addProducts = addProducts;

            if ((initProducts != null) && (initProducts.Count() != 0))
            {
                LoadProductsToCart(initProducts);
            }
        }

        private void CartList_DoubleClick(object sender, EventArgs e)
        {
            int countIndex = CartList.SelectedItems[0].SubItems.Count - 2;
            int priceIndex = CartList.SelectedItems[0].SubItems.Count - 1;
            
            ProductCountForm form = new ProductCountForm(SetCountProductsInCart,
                int.Parse(CartList.SelectedItems[0].SubItems[countIndex].Text),
                int.Parse(CartList.SelectedItems[0].SubItems[priceIndex].Text));
            form.ShowDialog();
        }

        private void Products_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)Products.SelectedItems[0].Tag;
            Product product = productRepository.Get(id);
            ListViewItem view = Converter.Convert(new[] { product }).First();
            ListViewItem item = Converter.Convert(CartList.Items).FirstOrDefault(el => (int)el.Tag == id);
            if (item == null)
            {
                CartList.Items.Add(view);
            }
            else
            {
                item.SubItems[item.SubItems.Count - 2].Text = 
                    (int.Parse(item.SubItems[item.SubItems.Count - 2].Text) + 1).ToString();
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadProducts()
        {
            Products.Items.AddRange(
                Converter.Convert(
                    productRepository
                    .GetAll()
                    .ToArray()));
        }

        private void LoadProductsToCart(KeyValuePair<Product, int>[] initProducts)
        {
            CartList.Items.AddRange(Converter.Convert(initProducts));
        }

        private void SetCountProductsInCart(int count, int price)
        {
            if (count == 0)
            {
                CartList.Items.Remove(CartList.SelectedItems[0]);
            }
            else
            {
                //index of count of product
                int indexCount = CartList.SelectedItems[0].SubItems.Count - 2;
                int indexPrice = CartList.SelectedItems[0].SubItems.Count - 1;
                CartList.SelectedItems[0].SubItems[indexCount].Text = count.ToString();
                CartList.SelectedItems[0].SubItems[indexPrice].Text = price.ToString();
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            addProducts(Converter.ToProducts(CartList.Items));
            Close();
        }

        private IProductRepository productRepository;
        private Action<KeyValuePair<IProduct, int>[]> addProducts;

        private void ResetCartButton_Click(object sender, EventArgs e)
        {
            CartList.Items.Clear();
        }
    }
}
