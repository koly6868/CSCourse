using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkClientServer.WorkerForms
{
    public partial class ReturnProductWindow : Form
    {
        public ReturnProductWindow(Func<string,bool> returnProducts)
        {
            InitializeComponent();
            this.returnProducts = returnProducts;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (returnProducts(DescriptionBox.Text))
            {
                Close();
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Func<string, bool> returnProducts;
    }
}
