﻿using Domain.Common;
using Domain.Infrastructure;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkClientServer.WorkerForms
{
    public partial class TransportManagerForm : Form
    {

        private void ProductsReponseTabConfigure()
        {
            responseProductRepository = ResponseProductRepository.GetInstace();
        }

        private void UpdateResponseTable()
        {
            ResponseList.Items.Clear();
            ResponseList.DisplayMember = "Description";
            ResponseList.Items.AddRange(responseProductRepository.GetAll().ToArray());
        }

        private void OnResponseTableTabSwitced()
        {
            UpdateResponseTable();
        }


        private void RetrunProductsButton_Click(object sender, EventArgs e)
        {
            ReturnProductWindow form = new ReturnProductWindow(ReturnProducts);
            form.ShowDialog();
        }

        private bool ReturnProducts(string descr)
        {
            ResponseProductcs products = (ResponseProductcs)ResponseList.SelectedItem;
            products.ReturnProduct(descr);
            if (responseProductRepository.Update(products))
            {
                UpdateResponseTable();
                return true;
            }
            else
            {
                return false;
            }
        }

        private ResponseProductRepository responseProductRepository;
    }
}
