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
    public partial class StaffForm : Form
    {
        string username;
        public StaffForm(string name)
        {
            InitializeComponent();
            this.username = name;
           
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm l = new LogInForm();
            l.Show();
        }

        private void POSWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoswindowForm poswindow = new PoswindowForm(username);
            poswindow.Show();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            Namelabel.Text = username;
            Timelabel.Text = DateTime.Now.ToString();
            timer.Start();
        }

        private void Timelabel_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString();
            timer.Start();
        }


        

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm purchase = new PurchaseForm();
            purchase.Show();
        }
    }
}
