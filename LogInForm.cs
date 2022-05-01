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
using DataAccess.Entities;
using DataAccess.Database;

namespace Restaurant_Management_System
{
    public partial class LogInForm : Form
    {
        Login login = new Login();
        LoginInformation loginInformation = new LoginInformation();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            login.Username = NametextBox.Text;
            login.Password = PasswordtextBox.Text;
            login.Usertype = TypecomboBox.Text;

            if (login.Username == string.Empty || login.Password == string.Empty || login.Usertype == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                bool flag = loginInformation.insertlogin(login);

                if (flag == true && login.Usertype == "Admin")
                {

                    this.Hide();
                    AdminForm admin = new AdminForm();
                    admin.Show();
                }
                else if (flag == true && login.Usertype == "Manager")
                {
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.Show();

                }
                else if (flag == true && login.Usertype == "Staff")
                {

                    this.Hide();
                    StaffForm staff = new StaffForm(login.Username);
                    staff.Show();
                }
                else
                {
                    MessageBox.Show("No data found please correct user name and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            NametextBox.Clear();
            PasswordtextBox.Clear();
            TypecomboBox.Text="";

        }


     

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(PasswordcheckBox.Checked)
            {
                PasswordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ResetUserNamePasswordForm reset = new ResetUserNamePasswordForm();
            reset.Show();
        }

        private void CreateaccountlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            UserRegistrationForm registration = new UserRegistrationForm();
            registration.Show();
            
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


