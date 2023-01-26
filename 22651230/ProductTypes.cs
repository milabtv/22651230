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
    public partial class ProductTypes : Form
    {
        public ProductTypes()
        {
            InitializeComponent();
        }
        public void LoadProdType()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectProdTypes();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "Name_";
            comboBox1.ValueMember = "ID";
            dataManager.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProductType prodType = new ProductType(textBox1.Text);
            DataManager dataManager = new DataManager();
            if (dataManager.InsertProdType(prodType))
                MessageBox.Show("Inserted");
            else MessageBox.Show("NOT Inserted");
            dataManager.Dispose();
            LoadProdType();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ProductType productType = new ProductType(textBox1.Text,int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.UpdateProdType(productType))
                MessageBox.Show("Updated");
            else MessageBox.Show("NOT Updated");
            LoadProdType();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductType productType = new ProductType(int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.DeleteProdType(productType))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadProdType();
        }

        private void ProductType_Load(object sender, EventArgs e)
        {
            LoadProdType();
        }
    }
}
