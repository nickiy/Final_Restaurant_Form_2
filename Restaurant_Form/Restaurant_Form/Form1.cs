using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet.Menu_Items' table. You can move, or remove it, as needed.
            this.menu_ItemsTableAdapter.Fill(this.ordersDataSet.Menu_Items);
            // TODO: This line of code loads data into the 'employeeDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.employeeDataSet1.Orders);
            timer2.Start();

        }

        private void tableTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.AddNew();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ordersBindingSource.RemoveCurrent();

        }

        int count = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            count = ordersBindingSource.Count;
            label1.Text = "There are " + count.ToString() + " orders in your database waiting";
            
        }
    }
}
