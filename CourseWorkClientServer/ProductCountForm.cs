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
    public partial class ProductCountForm : Form
    {
        public ProductCountForm(Action<int> handler)
        {
            InitializeComponent();
            this.handler = handler;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int count;
            try
            {
                count = int.Parse(CountBox.Text);
                if (count >= 0)
                {
                    handler(count);
                }
            }
            catch(Exception ex)
            {
                //todo
            }
            Close();
        }

        private Action<int> handler;
    }
}
