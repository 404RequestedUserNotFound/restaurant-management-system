using DataAccess.Entities;
using DataAccess.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class ManagerStaffSalaryForm : Form
    {
        ManagerStaff entitystaff = new ManagerStaff();
        OperationsStaff operationsStaff = new OperationsStaff();


        public ManagerStaffSalaryForm()
         {
             InitializeComponent();
         }

         private void btnInsert_Click(object sender, EventArgs e)
         {
             

             entitystaff.Name = txtName.Text;
             entitystaff.Id = txtId.Text;
             entitystaff.Salary = txtSalary.Text;
             int flag = operationsStaff.Insert(entitystaff);
             if (flag > 0)
             {
                 MessageBox.Show("successfully inserted");
             }
             else
             {
                 MessageBox.Show("not inserted");
             }
         }

         private void btnShow_Click(object sender, EventArgs e)
         {
             SqlDataAdapter sqlDataAdapter = operationsStaff.Show();
             DataTable dataTable = new DataTable();
             sqlDataAdapter.Fill(dataTable);
             dataGridView1.DataSource = dataTable;
         }

         private void btnUpdate_Click(object sender, EventArgs e)
         {
      

             entitystaff.Name = txtName.Text;
             entitystaff.Id = txtId.Text;
             entitystaff.Salary = txtSalary.Text;
             int flag = operationsStaff.Update(entitystaff);
             if (flag > 0)
             {
                 MessageBox.Show("successfully Updated");
             }
             else
             {
                 MessageBox.Show("not Updated");
             }
         }

         private void btnDelete_Click(object sender, EventArgs e)
         {
        

             entitystaff.Name = txtName.Text;
             entitystaff.Id = txtId.Text;
             entitystaff.Salary = txtSalary.Text;
             int flag = operationsStaff.Delete(entitystaff);
             if (flag > 0)
             {
                 MessageBox.Show("Successfully Deleted");
             }
             else
             {
                 MessageBox.Show("Not Deleted");
             }
         }

         private void btnBack_Click(object sender, EventArgs e)
         {
             new ManagerForm().Show();
             this.Hide();
         }

       
    }
}
