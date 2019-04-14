using Domain.Infrastructure;
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

namespace CourseWorkClientServer
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        public Orders(Form form, string connectionString)
        {
            InitializeComponent();
            this.form = form;
            contractsRepository = new ContractRepository(connectionString);
            
        }

        private void Orders_Load(object sender, EventArgs e)
        {
        }

        private void LoadContracts()
        {
            Contract[] contracts = contractsRepository.GetAll().ToArray();
            
        }

        private void Contracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private readonly IRepository<Contract> contractsRepository;
        private readonly Form form;
    }
}
