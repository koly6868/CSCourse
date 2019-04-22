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

namespace CourseWorkClientServer.ManagerForms
{
    public partial class CompanyFrom : Form
    {
        public CompanyFrom(Func<Company,bool> saveCompany)
        {
            InitializeComponent();
            companyRepository = CompanyRepository.GetInstance();
            this.saveCompany = saveCompany;
            companyID = -1;
        }

        public CompanyFrom(Func<Company, bool> saveCompany, Company company)
        {
            InitializeComponent();
            companyRepository = CompanyRepository.GetInstance();
            this.saveCompany = saveCompany;
            CompanyNameBox.Text = company.Name;
            CompanyRaitingBox.Text = company.Rating.ToString();
            FormOfompanyBox.Text = company.FormOfCompany;
            AdressBox.Items.AddRange(company.Adreses.ToArray());
            companyID = company.ID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Company company = null;
            try
            {
                company = new Company(
                    companyID,
                    CompanyNameBox.Text,
                    int.Parse(CompanyRaitingBox.Text),
                    FormOfompanyBox.Text
                    );
            }catch(Exception ex)
            {
                SetError("Incorrect data");
                return;
            }
            AdressOfDepartment[] adresses = AdressBox
                .Items
                .Cast<AdressOfDepartment>().
                ToArray();

            company.AddAdress(adresses);
            if (saveCompany(company))
            {
                Close();
            }
            else
            {
                SetError("Unable to save");
            }
        }

        private void SetError(string err)
        {
            ErrorLabel.Text = err;
            ErrorLabel.Visible = true;
        }

        private void AddAdressButton_Click(object sender, EventArgs e)
        {
            AdressForm form = new AdressForm(AddAdress);
            form.ShowDialog();
        }

        private void AddAdress(AdressOfDepartment adress)
        {
            AdressBox.Items.Add(adress);
            AdressBox.SelectedItem = adress;
        }

        private void AdressBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdressOfDepartment adress = GetSelectedAdress();
            PhoneBox.Text = adress.Phone;
        }

        private void DeleteAdresButon_Click(object sender, EventArgs e)
        {
            AdressBox.Items.Remove(AdressBox.SelectedItem);
            PhoneBox.Text = "";
            AdressBox.Text = "";
        }



        private void EditAdress_Click(object sender, EventArgs e)
        {
            AdressForm form = new AdressForm(UpdateAdress, GetSelectedAdress());
            form.ShowDialog();
        }

        private void UpdateAdress(AdressOfDepartment newAdress)
        {
            AdressOfDepartment adress = GetSelectedAdress();
            AdressBox.Items.Remove(adress);
            AdressBox.Items.Add(newAdress);
            AdressBox.SelectedItem = newAdress;
        }

        private AdressOfDepartment GetSelectedAdress()
        {
            return (AdressOfDepartment)AdressBox.SelectedItem;
        }

        private CompanyRepository companyRepository;
        private Func<Company, bool> saveCompany;
        private int companyID;
    }
}
