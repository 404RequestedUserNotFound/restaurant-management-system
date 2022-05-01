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
    public partial class ResetUserNamePasswordForm : Form
    {
        ResetUserNamePassword resetNamePassword = new ResetUserNamePassword();
        ResetUserNamePasswordInformation resetNamePasswordInformation = new ResetUserNamePasswordInformation();
        public ResetUserNamePasswordForm()
        {
            InitializeComponent();
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

        private void ResetUserNamePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AddresstextBox_TextChanged(object sender, EventArgs e)
        {
            AddresstextBox.Focus();
        }

       

      public void information()
        {
            resetNamePassword.Validemail = AddresstextBox.Text;
            resetNamePassword.Validphonenumber = NumbertextBox.Text;
            resetNamePassword.Newname = NewnametextBox.Text;
            resetNamePassword.Newpassword = PasswordtextBox.Text;
            resetNamePassword.Confirmpassword = ConfirmPasstextBox.Text;
        }
        public void clearinformation()
        {
            AddresstextBox.Text = string.Empty;
            NumbertextBox.Text = string.Empty;
            NewnametextBox.Text = string.Empty;
            PasswordtextBox.Text = string.Empty;
            ConfirmPasstextBox.Text = string.Empty;

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            information();

            if (resetNamePassword.Validemail == string.Empty || resetNamePassword.Validphonenumber == string.Empty || resetNamePassword.Validpassword == string.Empty || resetNamePassword.Newname == string.Empty || resetNamePassword.Newpassword == string.Empty || resetNamePassword.Confirmpassword == string.Empty)
            {
                MessageBox.Show("Please Fill up All Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PasswordtextBox.Text == ConfirmPasstextBox.Text)
                {
                    int flag = resetNamePasswordInformation.resetpassword(resetNamePassword);
                    if (flag > 0)
                    {
                        MessageBox.Show("User name and Password successfully reset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfully reset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            clearinformation();
        }
      

        private void ConfirmPasscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ConfirmPasscheckBox.Checked)
            {
                ConfirmPasstextBox.UseSystemPasswordChar = false;
            }
            else
            {
                ConfirmPasstextBox.UseSystemPasswordChar = true;
            }
        }

      
    }
}
