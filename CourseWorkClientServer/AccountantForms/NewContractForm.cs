using Domain.Common;
using Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static Domain.Common.Contract;

namespace CourseWorkClientServer.AccountantForms
{
    public partial class NewContractForm : Form
    {
        public NewContractForm()
        {
            InitializeComponent();
            contractBuilder = Contract.CreateBuilder();
            contractRepository = ContractRepository.GetInstance();
            companyRepository = CompanyRepository.GetInstance();
            LoadCompanies();
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

        private void AddTransportToContract(ITransport transport)
        {
            contractBuilder.SetTransport(transport);
            TransportValueLabel.Text = transport.TypeOfTransport;
        }


        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                contractBuilder.SetID(int.Parse(IDContractBox.Text));
                contractBuilder.SetDate(ContactDateBox.Value);
                if (contractRepository.Add(contractBuilder.Build()))
                {
                    Close();
                }
                else
                {
                    SetError("Unable to create");
                }
            }
            catch(Exception ex)
            {
                SetError("Incorrect data");
            }
        }

        private void SetError(string err)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = err;
        }


        private void AddTransportButton_Click(object sender, EventArgs e)
        {
            TransportAddForm form = new TransportAddForm(AddTransportToContract);
            form.ShowDialog();
        }

        private void NewContractForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadCompanies()
        {
            CompanyBox.Items.Clear();
            CompanyBox.Items.AddRange(companyRepository.GetAll().ToArray());
        }

        private void CompanyBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            contractBuilder.SetCompany((Company)CompanyBox.SelectedItem);
        }

        private ContractRepository contractRepository;
        private ContractBuilder contractBuilder;
        private CompanyRepository companyRepository;
    }
}
