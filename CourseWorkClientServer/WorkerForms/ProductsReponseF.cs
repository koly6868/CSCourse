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

namespace CourseWorkClientServer.WorkerForms
{
    public partial class ProductsReponseF : Form
    {
        public ProductsReponseF()
        {
            InitializeComponent();
            responseProductRepository = ResponseProductRepository.GetInstace();
        }

        private void LoadData()
        {
            ResponseList.Items.AddRange(responseProductRepository.GetAll().ToArray());
        }

        private void ProductsReponseFrom_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private ResponseProductRepository responseProductRepository;
    }
}
