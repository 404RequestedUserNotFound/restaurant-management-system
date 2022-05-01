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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Food_items_list().Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ManagerCustoInfo().Show();
            this.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            new ManagerStaffForm().Show();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ManagerStaffSalaryForm().Show();
            this.Show();
        }
    }
}
