using Domain.Common;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkClientServer.ManagerForms
{
    public partial class AdressForm : Form
    {
        public AdressForm(Action<AdressOfDepartment> addAdress)
        {
            InitializeComponent();
            this.addAdress = addAdress;
            IDAdress = -1;
        }

        public AdressForm(Action<AdressOfDepartment> addAdress, AdressOfDepartment adress)
        {
            InitializeComponent();
            this.addAdress = addAdress;
            CityBox.Text = adress.City;
            StreetBox.Text = adress.Street;
            BuildingBox.Text = adress.Building.ToString();
            PhoneBox.Text = adress.Phone;
            IDAdress = adress.ID;
        }

        private void AdressForm_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            AdressOfDepartment adress = null;
            if (!IsNumeric(PhoneBox.Text))
            {
                SetError("Incorrect phone");
                return;
            }
            try
            {
                adress = new AdressOfDepartment(
                    IDAdress,
                    CityBox.Text,
                    StreetBox.Text,
                    int.Parse(BuildingBox.Text),
                    PhoneBox.Text);
            }catch(Exception ex)
            {
                SetError("Incorrect data");
            }
            addAdress(adress);
            Close();
        }

        private void SetError(string err)
        {
            ErrorLabel.Text = err;
            ErrorLabel.Visible = true;
        }

        private bool IsNumeric(string phone)
        {
            return phone.Where(el => !char.IsDigit(el)).Count() == 0;
        }

        private Action<AdressOfDepartment> addAdress;
        private int IDAdress;
    }
}
