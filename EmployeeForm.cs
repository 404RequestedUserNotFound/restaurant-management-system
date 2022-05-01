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
    public partial class EmployeeForm : Form
    {
        Employee employee = new Employee();
        EmployeeInformation EmployeeInformation = new EmployeeInformation();

        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }



        public void information()
        {
            employee.Employeename = emptextname.Text;
            employee.Employeeid = emptextId.Text;
            employee.Employeesalary = emptextSalary.Text;
            employee.Employeecategory = TypecomboBox1.Text;

        }
        public void clearinformation()
        {
            emptextname.Text = "";
            emptextId.Text = "";
            emptextSalary.Text = "";
        }





        private void Addemp_Click(object sender, EventArgs e)
        {
            information();
            if (employee.Employeename == string.Empty || employee.Employeeid == string.Empty || employee.Employeesalary == string.Empty || employee.Employeecategory == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = EmployeeInformation.insertemployee(employee);
                if (flag > 0)
                {
                    MessageBox.Show("Employee Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull insertion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = EmployeeInformation.Dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }



        private void removeemp_Click(object sender, EventArgs e)
        {
            information();

            if (employee.Employeename == string.Empty || employee.Employeeid == string.Empty || employee.Employeesalary == string.Empty || employee.Employeecategory == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = EmployeeInformation.deleteemployee(employee);
                if (flag > 0)
                {
                    MessageBox.Show("Employee Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                DataTable dataTable = EmployeeInformation.Dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }




        private void Showemp_Click(object sender, EventArgs e)
        {


            DataTable dataTable = EmployeeInformation.Dataview();
            dataGridView1.DataSource = dataTable;
            textBox1.Text = dataGridView1.Rows.Count.ToString();
        }

        private void empsearch_Click(object sender, EventArgs e)
        {

            information();

            if (Empsearchbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dataTable = EmployeeInformation.searchemployee(Empsearchbox.Text);
                dataGridView1.DataSource = dataTable;

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            emptextname.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            emptextId.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            emptextSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TypecomboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Empsearchbox.Text = emptextId.Text;
        }

        private void Updateemp_Click(object sender, EventArgs e)
        {
            information();
            if (employee.Employeename == string.Empty || employee.Employeeid == string.Empty || employee.Employeesalary == string.Empty || employee.Employeecategory == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = EmployeeInformation.updateemployee(employee);
                if (flag > 0)
                {
                    MessageBox.Show("Employee Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = EmployeeInformation.Dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }
    }
}

