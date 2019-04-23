using System;
using System.Windows.Forms;

namespace CourseWorkClientServer.AccountantForms
{
    public partial class ProductCountForm : Form
    {
        public ProductCountForm(Action<int,int> handler, int productCount, int productPrice)
        {
            InitializeComponent();
            this.handler = handler;
            PriceBox.Text = productPrice.ToString();
            CountBox.Text = productCount.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int count;
            int price;
            try
            {
                count = int.Parse(CountBox.Text);
                price = int.Parse(PriceBox.Text);
                if (count >= 0 && price >= 0)
                {
                    handler(count, price);
                }
            }
            catch(Exception ex)
            {
                //todo
            }
            Close();
        }

        private Action<int,int> handler;
    }
}
