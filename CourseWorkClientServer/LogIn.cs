using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Infrastructure;
using Domain.Infrastructure.Security;
using Domain.Common;
using Microsoft.Extensions.Configuration;
using CourseWorkClientServer.AccountantForms;
using CourseWorkClientServer.WorkerForms;
using CourseWorkClientServer.ManagerForms;

namespace CourseWorkClientServer
{
    public partial class LogIn : Form
    {
        public LogIn(IConfiguration configuration)
        {
            this.configuration = configuration;
            InitializeComponent();
            SetColors();
            security = Security.GetInstance();
            security.Configurate(configuration["ConnectionStringForm"]);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            IResult<int> result = security.Authenticate(LoginBox.Text, PasswordBox.Text);
            if (result.IsOk)
            {
                RepositoryConfigure(security.GetConnectionString());
                Form form;
                switch ((Role)result.value)
                {
                    case Role.Manager:
                        form = new CompanyManagerForm(this);
                        form.Show();
                        break;
                    case Role.Worker:
                        form = new TransportManagerForm(this);
                        form.Show();
                        break;
                    case Role.Accountant:
                        form = new Orders(this);
                        form.Show();
                        break;
                    default:
                        SetError("unrecognized");
                        return;
                }
                Hide();
            }
            else
            {
                LoginBox.BackColor = Color.LightPink;
                PasswordBox.BackColor = Color.LightPink;
                SetError("Incorrect login or passord");
            }
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {
            ResetError();
        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            ResetError();
        }

        private void ResetError()
        {
            PasswordBox.BackColor = Color.White;
            LoginBox.BackColor = Color.White;
            errorLabel.Visible = false;
        }

        private void SetError(string error)
        {
            errorLabel.Visible = true;
            errorLabel.Text = error;
        }

        private void PressKeyHandler(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SignInButton_Click(sender, e);
                    break;

                default:
                    break;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void RepositoryConfigure(string connectionString)
        {
            ProductRepository.Configure(connectionString);
            ContractRepository.Configure(connectionString);
            TransportRepository.Configure(connectionString);
            CompanyRepository.Configure(connectionString);
            ResponseProductRepository.Configure(connectionString);
        }

        private readonly IConfiguration configuration;
        private readonly ISecurity security;
    }
}
