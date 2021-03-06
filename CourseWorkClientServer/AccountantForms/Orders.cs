﻿using Domain.Common;
using Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseWorkClientServer.AccountantForms
{
    public partial class Orders : Form
    {

        public Orders(Form form)
        {
            InitializeComponent();
            this.form = form;
            contractsRepository = ContractRepository.GetInstance();
            productRepository = ProductRepository.GetInstance();
            UpdateContracts();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void UpdateContracts()
        {
            Contracts.Items.Clear();
            Contract[] contracts = contractsRepository.GetAll().ToArray();
            Contracts.Items.AddRange(Converter.Convert(contracts));
        }

        private void Contracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Contracts.SelectedItems.Count != 0)
            {
                Products.Items.Clear();
                int id = (int)Contracts.SelectedItems[0].Tag;
                KeyValuePair<Product,int>[] products = productRepository.GetByContractID(id).ToArray();
                Products.Items.AddRange(Converter.Convert(products));
            }
        }

        private void SortButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem[] items = new ListViewItem[Contracts.Items.Count];
            //Sort
            switch (SortButton.SelectedItem)
            {
                case "ID":
                    Contracts.Items.CopyTo(items, 0);
                    Array.Sort(items, (a, b) => 
                    {
                        return int.Parse(a.SubItems[0].Text) -
                           int.Parse(b.SubItems[0].Text);
                    });
                    Contracts.Items.Clear();
                    Contracts.Items.AddRange(items);
                    break;
                case "date":
                    Contracts.Items.CopyTo(items, 0);
                    Array.Sort(items, (a, b) =>
                    {
                        return a.SubItems[2].Text.CompareTo(b.SubItems[2].Text);
                    });
                    Contracts.Items.Clear();
                    Contracts.Items.AddRange(items);
                    break;
            }
        }

        private void OnClosing(object sender, FormClosedEventArgs e)
        {
            form.Close();
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (Contracts.SelectedItems.Count != 0)
            {
                foreach(ListViewItem el in Contracts.SelectedItems)
                {
                    contractsRepository.Delete((int)el.Tag);
                }
            }
            UpdateContracts();
        }

        private readonly IRepository<Contract> contractsRepository;
        private readonly IProductRepository productRepository;
        private readonly Form form;

        private void Orders_Load_1(object sender, EventArgs e)
        {

        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NewContractForm form = new NewContractForm();
            form.ShowDialog();
            UpdateContracts();
        }
    }
}
