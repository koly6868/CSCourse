using Domain.Infrastructure;
using System;
using System.Linq;
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
