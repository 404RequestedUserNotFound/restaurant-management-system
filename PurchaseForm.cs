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
    public partial class PurchaseForm : Form
    {
        PurchaseInformation purchase = new PurchaseInformation();
        Purchase pur = new Purchase();
        public PurchaseForm()
        {
            InitializeComponent();
        }



        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '.' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void information()
        {
            pur.ItemName = ItemNametextBox.Text;
            pur.CustomerName = CustomerNametextBox.Text;
            pur.CustomerId =CustomerIdtextBox.Text;
         

        }
        public void cleainformation()
        {
            dateTimePicker1.Text = "";
            ItemNametextBox.Text="";
            CustomerNametextBox.Text="";
            CustomerIdtextBox.Text = "";
            PricetextBox.Text="0.0";
            QuantitytextBox.Text = "0"; 
            Totallabel.Text = "0";
        }
        //CustomerNametextBox.Text == string.Empty || CustomerIdtextBox.Text == string.Empty ||
        private void Addbutton_Click(object sender, EventArgs e)
        {
            information();
            if (ItemNametextBox.Text == string.Empty ||  CustomerNametextBox.Text == string.Empty || CustomerIdtextBox.Text == string.Empty || QuantitytextBox.Text == string.Empty || PricetextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pur.Date = dateTimePicker1.Value;
                pur.Price = float.Parse(PricetextBox.Text);
                pur.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                pur.TotalPrice = pur.Price * pur.Quantity;
                Totallabel.Text = pur.TotalPrice.ToString();
                int flag = purchase.addpurchase(pur);
                if (flag > 0)
                {
                    MessageBox.Show("Purchase Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = purchase.dataview(ItemNametextBox.Text);
                dataGridView1.DataSource = dataTable;
            }
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
            cleainformation();
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            information();
            if (ItemNametextBox.Text == string.Empty || CustomerNametextBox.Text == string.Empty || CustomerIdtextBox.Text == string.Empty ||  QuantitytextBox.Text == string.Empty || PricetextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pur.Date = dateTimePicker1.Value;
                pur.Price = float.Parse(PricetextBox.Text);
                pur.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                pur.TotalPrice = pur.Price * pur.Quantity;
                Totallabel.Text = pur.TotalPrice.ToString();
                int flag = purchase.Editpurchase(pur);
                if (flag > 0)
                {
                    MessageBox.Show("Purchase Data Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = purchase.dataview(ItemNametextBox.Text);
                dataGridView1.DataSource = dataTable;
            }
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
            cleainformation();
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            information();
            if (ItemNametextBox.Text == string.Empty || CustomerNametextBox.Text == string.Empty || CustomerIdtextBox.Text == string.Empty || QuantitytextBox.Text == string.Empty || PricetextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pur.Date = dateTimePicker1.Value;
                pur.Price = float.Parse(PricetextBox.Text);
                pur.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                pur.TotalPrice = pur.Price * pur.Quantity;
                Totallabel.Text = pur.TotalPrice.ToString();
                int flag = purchase.removepurchase(pur);
                if (flag > 0)
                {
                    MessageBox.Show("Purchase Data Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull Delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = purchase.dataview(ItemNametextBox.Text);
                dataGridView1.DataSource = dataTable;
            }
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
            cleainformation();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString();
            CustomerNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customername"].Value.ToString();
            CustomerIdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["customerid"].Value.ToString();
           QuantitytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            PricetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
           Totallabel.Text= dataGridView1.Rows[e.RowIndex].Cells["totalprice"].Value.ToString();
            SearchItemtextBox.Text = ItemNametextBox.Text;
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            information();

            if (SearchItemtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dataTable = purchase.searchpurchase(SearchItemtextBox.Text);
                dataGridView1.DataSource = dataTable;

            }
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
        }

        private void PuechaseListbutton_Click(object sender, EventArgs e)
        {
            List<Purchase> list = purchase.purchaselist();
            dataGridView1.DataSource = list;
            TotalPricelabel.Visible = true;
            Totallabel.Visible = true;
            sum();
        }
       

        public void sum()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            Totallabel.Text = sum.ToString();
        }

        private void CustomerIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '-' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '-' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemNametextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
