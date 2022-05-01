using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DataAccess.Database;

namespace Restaurant_Management_System
{
    public partial class AdminForm : Form
    {
        

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm l = new LogInForm();
            l.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustoForm cus = new CustoForm();
            cus.Show();
        }

        private void foodListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodForm food = new FoodForm();
            food.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm logIn = new LogInForm();
            logIn.ShowDialog();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UserRegistrationForm user = new UserRegistrationForm();
            user.ShowDialog();
        }

       
    }
}
