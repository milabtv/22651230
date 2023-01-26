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
    public partial class Shipments : Form
    {
        public Shipments()
        {
            InitializeComponent();
        }
        Shipment shipment = new Shipment();
        public void LoadWorkers()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectWorkers();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "ID";
            dataManager.Dispose();
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
        public void LoadCouriers()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectCouriers();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "ID";
        }
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Shipments_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadCouriers();
            LoadProducts();
            LoadWorkers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShipmentPackage pack = new ShipmentPackage(int.Parse(comboBox4.SelectedItem.ToString()), int.Parse(textBox4.Text));
            shipment.PackageAdd(pack);
            listView1.Items.Add(comboBox4.DisplayMember.ToString() +"  Quantity: " +textBox4.Text);
        }
    }
}
