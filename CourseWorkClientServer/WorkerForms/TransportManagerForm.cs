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

namespace CourseWorkClientServer.WorkerForms
{
    public partial class TransportManagerForm : Form
    {
        public TransportManagerForm(Form form)
        {
            InitializeComponent();
            ProductsReponseTabConfigure();
            mainFrom = form;
            transportRepository = TransportRepository.GetInstance();
            UpdateTransports();
        }

        private void UpdateTransports()
        {
            TransportList.Items.Clear();
            TransportList.DisplayMember = "Description";
            TransportList.Items.AddRange(transportRepository.GetAll().ToArray());
        }

        private void OnClosing(object sender, FormClosedEventArgs e)
        {
            mainFrom.Close();
        }


        private void TransportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool AddTransport(Transport transport)
        {
            if (transportRepository.Add(transport))
            {
                UpdateTransports();
                return true;
            }
            else return false;
        }

        private bool EditTransport(Transport transport)
        {
            if (transportRepository.Update(transport))
            {
                UpdateTransports();
                return true;
            }
            else return false;
        }

        private void AddTransportButton_Click(object sender, EventArgs e)
        {
            TransportFrom form = new TransportFrom(AddTransport);
            form.ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateTransports();
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            TransportFrom form = new TransportFrom(
                (Transport)TransportList.SelectedItem,
                EditTransport);
            form.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Transport transport = (Transport)TransportList.SelectedItem;
            if (transport == null) return;

            if (transportRepository.Delete(transport.ID))
            {
                TransportList.Items.Remove(transport);
            }
            else
            {
                ErrorFormcs error = new ErrorFormcs("Unable to delite");
                error.ShowDialog();
            }
        }

        private IRepository<Transport> transportRepository;
        private Form mainFrom;

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Tab tab = (Tab)tabControl.SelectedTab.Tag;

            switch (tab)
            {
                case Tab.Transport:
                    OnTranportTabSwitced();
                    break;

                case Tab.ResponseTable:
                    OnResponseTableTabSwitced();
                    break;
            }
        }

        private void OnTranportTabSwitced()
        {
            UpdateTransports();
        }
    }
}
