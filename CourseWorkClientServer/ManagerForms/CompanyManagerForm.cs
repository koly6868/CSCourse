using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Domain.Infrastructure;
using Domain.Common;
using CourseWorkClientServer;

namespace CourseWorkClientServer.ManagerForms
{
    public partial class CompanyManagerForm : Form
    {
        public CompanyManagerForm(Form mainForm)
        {
            InitializeComponent();
            companyRepository = CompanyRepository.GetInstance();
            this.mainForm = mainForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCompanyList();
        }

        private void UpdateCompanyList()
        {
            CompanyList.Items.Clear();
            CompanyList.Items.AddRange(
                Converter.Convert(
                    companyRepository.GetAll()));                 
        }



        private void CompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private bool AddCompany(Company company)
        {
            if (companyRepository.Add(company))
            {
                UpdateCompanyList();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool EditCompany(Company company)
        {
            if (companyRepository.Update(company))
            {
                UpdateCompanyList();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            CompanyFrom form = new CompanyFrom(EditCompany, GetSelectedCompany());
            form.ShowDialog();
        }

        private void NewCompanyButton_Click(object sender, EventArgs e)
        {
            CompanyFrom form = new CompanyFrom(AddCompany);
            form.ShowDialog();
        }

        private void DeleteCompanyButton_Click(object sender, EventArgs e)
        {
            int id = (int)CompanyList.SelectedItems[0].Tag;
            if (companyRepository.Delete(id))
            {
                UpdateCompanyList();
            }
            else
            {
                ErrorForm error = new ErrorForm("Unable to delete");
                error.ShowDialog();
            }
        }

        private Company GetSelectedCompany()
        {
            int id = (int)CompanyList.SelectedItems[0].Tag;
            return companyRepository.Get(id);
        }

        private IRepository<Company> companyRepository;
        private Form mainForm;
    }
}
