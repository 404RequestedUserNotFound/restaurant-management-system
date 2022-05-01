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
    public partial class CustoForm : Form
    {
        Cus cus = new Cus();
        CustoInfo custoInfo = new CustoInfo();
        public CustoForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            information();
            if (cus.CustomerName == string.Empty || cus.CustomerId == string.Empty || cus.CustomerAddress == string.Empty || cus.CustomerContactNo == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = custoInfo.insertcustomer(cus);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull insertion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = custoInfo.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            IdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AddresstextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ContacttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            SearchtextBox.Text = IdtextBox.Text;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            information();

            if (SearchtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dataTable = custoInfo.searchcustomer(SearchtextBox.Text);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            information();

            if (cus.CustomerName == string.Empty || cus.CustomerId == string.Empty || cus.CustomerAddress == string.Empty || cus.CustomerContactNo == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = custoInfo.deletecustomer(cus);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                DataTable dataTable = custoInfo.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }
        public void information()
        {
            cus.CustomerName = NametextBox.Text;
            cus.CustomerId = IdtextBox.Text;
            cus.CustomerAddress = AddresstextBox.Text;
            cus.CustomerContactNo = ContacttextBox.Text;

        }
        public void clearinformation()
        {
            NametextBox.Text = "";
            IdtextBox.Text = "";
            ContacttextBox.Text = "";
            AddresstextBox.Text = "";
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            information();
            if (cus.CustomerName == string.Empty || cus.CustomerId == string.Empty || cus.CustomerAddress == string.Empty || cus.CustomerContactNo == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = custoInfo.updatecustomer(cus);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = custoInfo.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }

        private void ShowCustomer_Click(object sender, EventArgs e)
        {
            DataTable dataTable = custoInfo.dataview();
            dataGridView1.DataSource = dataTable;
        }
    }
}
