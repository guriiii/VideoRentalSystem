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
    public partial class UpdateAndDeleteCust : Form
    {
        public UpdateAndDeleteCust()
        {
            InitializeComponent();
        }

        private void BtnUpdateCustomer_Click(object sender, EventArgs e)//method for updating the customer
        {
            DatabaseFunctions database = new DatabaseFunctions();
            database.editcustomer(txtFirstName.Text, txtAddress.Text, txtPhoneNo.Text, txtCustID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void BtnDaleteCustomer_Click(object sender, EventArgs e)//Method for deleting the customer
        {
            DatabaseFunctions database = new DatabaseFunctions();
            database.deletecustomer(txtCustID.Text);
            MessageBox.Show("Customer Deleted");
            Dispose();
        }
    }
}
