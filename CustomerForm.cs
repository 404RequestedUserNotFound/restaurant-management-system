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
    public partial class CustomerForm : Form
    {
        Customer customer = new Customer();
        CustomerInformation customerInformation = new CustomerInformation();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            information();
            if (customer.CustomerName == string.Empty || customer.CustomerId == string.Empty || customer.CustomerAddress == string.Empty || customer.CustomerContact == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = customerInformation.insertcustomer(customer);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull insertion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = customerInformation.dataview(NametextBox.Text,IdtextBox.Text,AddresstextBox.Text,ContacttextBox.Text);
                dataGridView1.DataSource = dataTable;

            }
            TotalCustomerlabel.Visible = false;
            Totallabel.Visible = false;
            clearinformation();
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            IdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customerid"].Value.ToString();
            NametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customername"].Value.ToString();
            AddresstextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customeraddress"].Value.ToString();
            ContacttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customercontact"].Value.ToString();
            SearchtextBox.Text = IdtextBox.Text;
            Totallabel.Text = string.Empty;
            TotalCustomerlabel.Visible = false;
            Totallabel.Visible = false;

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            information();
            
           if (SearchtextBox.Text==string.Empty)
            {
               MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
            {
                
                DataTable dataTable = customerInformation.searchcustomer(SearchtextBox.Text);
                dataGridView1.DataSource = dataTable;
               
           }
            TotalCustomerlabel.Visible = false;
            Totallabel.Visible = false;
            clearinformation();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            information();
         
            if (customer.CustomerName == string.Empty || customer.CustomerId == string.Empty || customer.CustomerAddress == string.Empty || customer.CustomerContact == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = customerInformation.deletecustomer(customer);
                if(flag>0)
                {
                    MessageBox.Show("Customer Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                DataTable dataTable = customerInformation.dataview(NametextBox.Text, IdtextBox.Text, AddresstextBox.Text, ContacttextBox.Text);
                dataGridView1.DataSource = dataTable;
            }
            TotalCustomerlabel.Visible = false;
            Totallabel.Visible = false;
            clearinformation();
        }
        public void information()
        {
            customer.CustomerName = NametextBox.Text;
            customer.CustomerId = IdtextBox.Text;
            customer.CustomerAddress = AddresstextBox.Text;
            customer.CustomerContact = ContacttextBox.Text;
           
        }
        public void clearinformation()
        {
            NametextBox.Text = "";
            IdtextBox.Text = "";
            ContacttextBox.Text = "";
            AddresstextBox.Text = "";
            SearchtextBox.Text = string.Empty;
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            information();
            if (customer.CustomerName == string.Empty || customer.CustomerId == string.Empty || customer.CustomerAddress == string.Empty || customer.CustomerContact == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = customerInformation.updatecustomer(customer);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = customerInformation.dataview(NametextBox.Text, IdtextBox.Text, AddresstextBox.Text, ContacttextBox.Text);
                dataGridView1.DataSource = dataTable;
            }
            TotalCustomerlabel.Visible = false;
            Totallabel.Visible = false;
            clearinformation();
        }

        private void Customerlistbutton_Click(object sender, EventArgs e)
        {
            List<Customer> list = customerInformation.custonerlist();
            dataGridView1.DataSource = list;
            TotalCustomerlabel.Visible = true;
            Totallabel.Visible = true;
            Totallabel.Text = dataGridView1.Rows.Count.ToString();
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '-' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContacttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '-' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Totallabel_Click(object sender, EventArgs e)
        {

        }
    }
}
