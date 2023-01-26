﻿using _22651230.ClassModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22651230
{
    public partial class Clients : Form
    {
        public void LoadClients()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectClients();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "ID";
            dataManager.Dispose();
        }
        public Clients()
        {
            InitializeComponent();
        }

        
        private void Clients_Load(object sender, EventArgs e)
        {
            LoadClients();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Client client = new Client(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text);
            DataManager dataManager = new DataManager();
            if (dataManager.InsertClients(client))
                MessageBox.Show("Inserted");
            else MessageBox.Show("NOT Inserted");
            dataManager.Dispose();
            LoadClients();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Client client = new Client(textBox1.Text, textBox3.Text, textBox2.Text, textBox4.Text, int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.UpdateClients(client))
                MessageBox.Show("Updated");
            else MessageBox.Show("NOT Updated");
            LoadClients();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Client client = new Client(int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.DeleteClients(client))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadClients();
        }
    }
}
