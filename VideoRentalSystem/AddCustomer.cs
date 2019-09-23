using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalSystem
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)//This is add customer method
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                DatabaseFunctions database = new DatabaseFunctions();
                database.addnewcustomer(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}
