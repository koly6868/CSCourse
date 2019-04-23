using Domain.Common;
using Domain.Infrastructure;
using System;
using System.Linq;
using System.Windows.Forms;

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
            try
            {
                int id = (int)TransportList.SelectedItems[0].Tag;
                setTransport(transportRepository.Get(id));
                Close();
            }
            catch (Exception e)
            {
                SetError("incorrect data");
            }
        }

        private void SetError(string err)
        {
            ErrorLabel.Visible = true;
            ErrorLabel.Text = err;
        }

        private void LoadTransports()
        {
            TransportList.Items.AddRange(Converter.Convert(transportRepository.GetAll().ToArray()));
        }

        private IRepository<Transport> transportRepository;
        private Action<ITransport> setTransport;
    }
}
