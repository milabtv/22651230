using Spire.Xls;
using System;
using System.Collections;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Workers frm = new Workers();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clients frm = new Clients();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Couriers frm = new Couriers();
            frm.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Productws frm = new Productws();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Shipments frm = new Shipments();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductTypes frm = new ProductTypes();
            frm.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            //Workbook book = new Workbook();
            //Worksheet sheet = book.Worksheets[0];
            //sheet.InsertDataTable(t, true, 1, 1);
            //book.SaveToFile("ToExcel.xls");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
