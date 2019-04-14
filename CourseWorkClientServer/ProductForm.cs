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

namespace CourseWorkClientServer
{
    public partial class ProductForm : Form
    {
        public ProductForm(string connectionString)
        {
            InitializeComponent();
            productRepository
        }

        private void CartList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Products_DoubleClick(object sender, EventArgs e)
        {
            CartList.Items.AddRange(Converter.Convert(Products.SelectedItems));
        }

        private IProductRepository productRepository;
    }
}
