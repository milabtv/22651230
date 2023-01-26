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
    public partial class Couriers : Form
    {
        public Couriers()
        {
            InitializeComponent();
        }
        public void LoadCouriers()
        {
            DataManager dataManager = new DataManager();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = dataManager.SelectCouriers();
            comboBox1.DataSource = bindingSource1.DataSource;
            comboBox1.DisplayMember = "FirstName";
            comboBox1.ValueMember = "ID";
            dataManager.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Courier couriers = new Courier(textBox1.Text, float.Parse(textBox3.Text));
            DataManager dataManager = new DataManager();
            if (dataManager.InsertCouriers(couriers))
                MessageBox.Show("Inserted");
            else MessageBox.Show("NOT Inserted");
            dataManager.Dispose();
           LoadCouriers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Courier courier = new Courier(textBox1.Text, float.Parse(textBox3.Text), int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.UpdateCouriers(courier))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadCouriers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Courier courier = new Courier(int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.DeleteCouriers(courier))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadCouriers();
        }

        private void Couriers_Load(object sender, EventArgs e)
        {
            LoadCouriers();
        }
    }
}
