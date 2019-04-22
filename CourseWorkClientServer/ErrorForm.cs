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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string err)
        {
            InitializeComponent();
            richTextBox1.Text = err;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
