using DataAccess.Database;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ManagerCustoInfo : Form
    {
        public ManagerCustoInfo()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ManagerCustomer entityCustomer = new ManagerCustomer();
            OperationsCustomer operationsCustomer = new OperationsCustomer();

            entityCustomer.Name = txtName.Text;
            entityCustomer.Email = txtEmail.Text;
            entityCustomer.Address = txtAddress.Text;
            entityCustomer.Phonenumber = txtPhone.Text;
            entityCustomer.Serialnumber = txtSerial.Text;
            entityCustomer.Transactionover = comTran.Text;

            operationsCustomer.Insert(entityCustomer);
            int flag = operationsCustomer.Insert(entityCustomer);
            if (flag > 0)
            {
                MessageBox.Show("Successfully inserted");
            }
            else
            {
                MessageBox.Show("Not inserted");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new ManagerForm().Show();
            this.Hide();
        }
    }
}
