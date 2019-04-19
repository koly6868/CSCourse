using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Domain.Infrastructure;
using Domain.Common;

namespace CourseWorkClientServer
{
    public partial class Form1 : Form
    {
        public Form1(IConfiguration configuration)
        {
            this.configuration = configuration;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void UpdateForm()
        {
            //Company list update
            CompanyList.Items.AddRange(
                repository
                .GetAll()
                    .Select(el =>
                    {
                        var item = new ListViewItem(new string[] { el.Name, el.Rating.ToString() });
                        item.Tag = el.ID;
                        
                        return item;
                    })
                    .ToArray());           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CompanyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update Company form
            ListViewItem el = CompanyList.FocusedItem;
            int ID = (int)el.Tag;
            Company company = repository.Get(ID);
            //Name
            CompanyName.Text = company.Name;
            //Raiting
            CompanyRaiting.Text = company.Rating.ToString();
            //Adresses
            Adress.Items.Clear();
            AdressOfDepartment[] adresses = repository.Get(ID).Adreses.ToArray();
            Adress.Items.AddRange(adresses);
            Adress.Text = adresses.First().ToString();
            //Phone
            Phone.Text = adresses.First().Phone;
            
        }

        IRepository<Company> repository;
        private readonly IConfiguration configuration;

        private void AdressButton_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdressOfDepartment adress = (AdressOfDepartment)Adress.SelectedItem;
            Phone.Text = adress.Phone;
        }
    }
}
