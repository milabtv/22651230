using _22651230.ClassModel;
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
    public partial class Productws : Form
    {
        public Productws()
        {
            InitializeComponent();
        }
        public void LoadProducts()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectProducts();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "Name_";
            comboBox1.ValueMember = "ID";
            dataManager.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductType pt = new ProductType(int.Parse(textBox4.Text));
            Product prod = new Product(textBox1.Text, float.Parse(textBox3.Text), int.Parse(textBox2.Text),pt );
            DataManager dataManager = new DataManager();
            if (dataManager.InsertProducts(prod))
                MessageBox.Show("Inserted");
            else MessageBox.Show("NOT Inserted");
            dataManager.Dispose();
            LoadProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductType pt = new ProductType(int.Parse(textBox4.Text));
            Product prod = new Product(textBox1.Text, float.Parse(textBox3.Text), int.Parse(textBox2.Text), pt, int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.UpdateProducts(prod))
                MessageBox.Show("Updated");
            else MessageBox.Show("NOT Updated");
            LoadProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product prod = new Product(int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.DeleteProducts(prod))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadProducts();
        }

        private void Productws_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }

}
