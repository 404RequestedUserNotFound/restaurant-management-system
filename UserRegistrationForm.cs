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
    public partial class UserRegistrationForm : Form
    {
       
        UserRegistration user = new UserRegistration();
        RegistrationInformation registration = new RegistrationInformation();
        public UserRegistrationForm()
        {
            InitializeComponent();
            
        }

       

        private void SingupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            //if (NametextBox.Text == string.Empty || EmailtextBox.Text == string.Empty || AddresstextBox.Text == string.Empty || PasswordtextBox.Text == string.Empty || TypecomboBox.Text == string.Empty || DatetextBox.Text == string.Empty || PhonenumbertextBox.Text == string.Empty)
            //{
            //  MessageBox.Show("Please Fill up All Field And Must be Sing Up", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            // else
           
               this.Hide();
               LogInForm logInForm = new LogInForm();
               logInForm.Show();
    }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {
            NametextBox.Focus();
        }

        private void Singupbutton_Click(object sender, EventArgs e)
        {

            information();
       

            if (user.Username==string.Empty||user.Email==string.Empty||user.Address==string.Empty||user.Password==string.Empty||user.Usertype==string.Empty||user.Phonenumber==string.Empty)
            {
                MessageBox.Show("Please Fill up All Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (MaleradioButton.Checked == true)
                {
                    int flag1 = registration.insertregistration(user);

                    if (flag1 > 0)
                    {
                        MessageBox.Show("Account created Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {
                    int flag2 = registration.insert(user);
                    if (flag2 > 0)
                    {
                        MessageBox.Show("Account created Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                DataTable dataTable = registration.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();

        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordcheckBox.Checked)
            {
                PasswordtextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordtextBox.UseSystemPasswordChar = true;
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker.Format = DateTimePickerFormat.Custom;
           // dateTimePicker.CustomFormat = "yyyy/MM/dd hh:mm:ss";
           // DateTime iDate = dateTimePicker.Value;
           // iDate = dateTimePicker.Value;
            //MessageBox.Show("Current date is " + iDate);

            
        }
        void information()
        {
            user.Username = NametextBox.Text;
            user.Email = EmailtextBox.Text;
            user.Address = AddresstextBox.Text;
            user.Password = PasswordtextBox.Text;
            user.Usertype = TypecomboBox.Text;
            user.Malegender = MaleradioButton.Text;
            user.Femalegender = FemaleradioButton.Text;
            user.Date = dateTimePicker.Text;
            user.Phonenumber = PhonenumbertextBox.Text;
        }
        public void clearinformation()
        {
            NametextBox.Text="";
            EmailtextBox.Text="";
            AddresstextBox.Text="";
            PasswordtextBox.Text="";
            TypecomboBox.Text="";
            MaleradioButton.Checked=false;
            FemaleradioButton.Checked=false;
            dateTimePicker.Text="";
            PhonenumbertextBox.Text="";
        }
    }
}
