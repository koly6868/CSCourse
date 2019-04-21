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
using Domain.Infrastructure;

namespace CourseWorkClientServer.AccountantForms
{
    public partial class TransportAddForm : Form
    {
        public TransportAddForm(Action<ITransport> setTransport)
        {
            InitializeComponent();
            this.setTransport = setTransport;
            transportRepository = TransportRepository.GetInstance();
            LoadTransports();
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            OnChoosingTransport();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            OnChoosingTransport();
        }

        private void OnChoosingTransport()
        {
            int id = (int)TransportList.SelectedItems[0].Tag;
            setTransport(transportRepository.Get(id));
            Close();
        }

        private void LoadTransports()
        {
            TransportList.Items.AddRange(Converter.Convert(transportRepository.GetAll().ToArray()));
        }

        private IRepository<Transport> transportRepository;
        private Action<ITransport> setTransport;
    }
}
