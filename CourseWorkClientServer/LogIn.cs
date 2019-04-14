using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Infrastructure.Security;
using Domain.Common;
using Microsoft.Extensions.Configuration;

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
                switch ((Roles)result.value)
                {
                    case Roles.Buyer:
                        //
                        break;
                    case Roles.Worker:
                        //to Workers form
                        break;
                    case Roles.Accountant:
                        Orders form = new Orders(this, security.GetConnectionString());
                        form.Show();
                        break;
                    default:
                        SetError("unrecognized");
                        break;
                }
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
        private readonly IConfiguration configuration;
        private readonly ISecurity security;

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
