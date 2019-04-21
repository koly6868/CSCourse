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

        private void ProductsReponseTabConfigure()
        {
            responseProductRepository = ResponseProductRepository.GetInstace();
        }

        private void LoadData()
        {
            ResponseList.DisplayMember = "Description";
            ResponseList.Items.AddRange(responseProductRepository.GetAll().ToArray());
        }

        private void OnResponseTableTabSwitced()
        {
            LoadData();
        }

        private ResponseProductRepository responseProductRepository;
    }
}
