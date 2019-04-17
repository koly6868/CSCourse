using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Common;
using static Domain.Common.Contract;

namespace CourseWorkClientServer
{
    public partial class NewContractForm : Form
    {
        public NewContractForm()
        {
            InitializeComponent();
            contractBuilder = Contract.CreateBuilder();
        }

        private void AddProductsButton_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(AddProductsToContract,
                contractBuilder.ShowProducts()
                .Select(item => new KeyValuePair<Product,int>((Product)item.Key,item.Value))
                .ToArray());
            form.ShowDialog();
        }

        private void AddProductsToContract(KeyValuePair<IProduct,int>[] products)
        {
            contractBuilder.SetProducts(products);
            ContProductsValueLabel.Text = products.Sum(el => el.Value).ToString();
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                contractBuilder.SetID(int.Parse(IDContractBox.Text));
                contractBuilder.SetDate(ContactDateBox.Value);

                contractBuilder.Build();
            }
            catch(Exception ex)
            {
                ErrorLabel.Visible = true;
            }
        }

        private ContractBuilder contractBuilder;

        private void AddTransportButton_Click(object sender, EventArgs e)
        {

        }

        private void NewContractForm_Load(object sender, EventArgs e)
        {

        }
    }
}
