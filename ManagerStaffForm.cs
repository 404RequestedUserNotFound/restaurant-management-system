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
    public partial class ManagerStaffForm : Form
    {
        public ManagerStaffForm()
        {
            InitializeComponent();
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            int rownumber1 = dataGridView1.Rows.Add();
            dataGridView1.Rows[rownumber1].Cells[0].Value = comName.Text;
            dataGridView1.Rows[rownumber1].Cells[1].Value = comID.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbtnMale.Checked)
            {
                MessageBox.Show(rbtnMale.Text);
            }
            else
            {
                MessageBox.Show(rbtnFemale.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ManagerForm().Show();
            this.Hide();
        }
    }
}
