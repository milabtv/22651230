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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }
        
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(textBox1.Text, textBox3.Text, textBox2.Text);
            DataManager dataManager = new DataManager();
            if (dataManager.InsertWorkers(worker))
                MessageBox.Show("Inserted");
            else MessageBox.Show("NOT Inserted");
            dataManager.Dispose();
            LoadWorkers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(textBox1.Text, textBox3.Text, textBox2.Text, int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.UpdateWorkers(worker))
                MessageBox.Show("Updated");
            else MessageBox.Show("NOT Updated");
            LoadWorkers();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(int.Parse(comboBox1.SelectedValue.ToString()));
            DataManager dataManager = new DataManager();
            if (dataManager.DeleteWorkers(worker))
                MessageBox.Show("Deleted");
            else MessageBox.Show("NOT Deleted");
            LoadWorkers();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            LoadWorkers();
        }
    }
}
