using Domain.Common;
using System;
using System.Windows.Forms;

namespace CourseWorkClientServer.WorkerForms
{
    public partial class TransportFrom : Form
    {
        public TransportFrom(Func<Transport,bool> addTransport)
        {
            InitializeComponent();
            FuncFoAct = addTransport;
            OldtransportID = -1;
        }

        public TransportFrom(Transport transport, Func<Transport, bool> EditTransport)
        {
            InitializeComponent();
            PriceBox.Text = transport.Price.ToString();
            TimeOfDeliveryBox.Text = transport.TimeOfDelivery.ToString();
            NameTransportBox.Text = transport.TypeOfTransport;
            MaxWeightBox.Text = transport.MaxWeight.ToString();
            FuncFoAct = EditTransport;
            OldtransportID = transport.ID;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Transport transport = null;
            try
            {
                transport = new Transport(
                    OldtransportID,
                    int.Parse(PriceBox.Text),
                    int.Parse(TimeOfDeliveryBox.Text),
                    NameTransportBox.Text,
                    int.Parse(MaxWeightBox.Text)
                    );
                if (FuncFoAct(transport))
                {
                    Close();
                }
                else
                {
                    SetError("Somthing went wrong");
                }
            }
            catch(Exception ex)
            {
                SetError("Incorrect data");
            }
        }

        private void SetError(string err)
        {
            ErrorLabel.Text = err;
            ErrorLabel.Visible = true;
        }

        private Func<Transport, bool> FuncFoAct;
        private int OldtransportID;
        private enum Mode { Edit, Add }
    }
}
