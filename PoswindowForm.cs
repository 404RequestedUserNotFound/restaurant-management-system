using DataAccess.Database;
using DataAccess.Entities;
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
    public partial class PoswindowForm : Form
    {
        PosWindow pos = new PosWindow();
        PoswindowInformation poswindow = new PoswindowInformation();
        public ListViewItem viewItem;
        string username;
        public PoswindowForm(string name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void PoswindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
        void information()
        {

            DataTable dataTable = poswindow.search(ItemtextBox.Text);
            dataGridView1.DataSource = dataTable;
        }

       
        private void PoswindowForm_Load(object sender, EventArgs e)
        {
            CashiertextBox.Text = username;
            Timelabel.Text = DateTime.Now.ToString();
            timer.Start();
            information();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Timelabel.Text = DateTime.Now.ToString();
            timer.Start();
        }

        private void Receiptbutton_Click(object sender, EventArgs e)
        {
            if(ItemNametextBox.Text==string.Empty||ItemPricetextBox.Text==string.Empty||ItemQuantitytextBox.Text==string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                if(PaymentTypecomboBox.Text=="cash")

                {
                    pos.SaleDate = Convert.ToDateTime(Timelabel.Text);
                    pos.Cashiername = CashiertextBox.Text;
                    pos.Customerid = IdtextBox.Text;
                    pos.ItemName = ItemNametextBox.Text;                                 
                    pos.ItemPrice = float.Parse(ItemPricetextBox.Text);
                    pos.ItemQuentity = int.Parse(ItemQuantitytextBox.Text);
                    pos.TotalPrice = float.Parse(TotalPricetextBox.Text);
                    pos.Vat = Convert.ToInt32(VattextBox.Text);
                    pos.TotalPayment = Convert.ToSingle(TotalPaymenttextBox.Text);
                    pos.CashPayment = PaymentTypecomboBox.Text = "cash";
                    pos.PaidAmount = Convert.ToSingle(PaidAmounttextBox.Text);
                    pos.ReturnAmount = float.Parse(ReturnedAmounttextBox.Text);
                    int flag = poswindow.add(pos);
                    if (flag > 0)
                    {
                        MessageBox.Show("Item Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                else
                {
                    pos.SaleDate = Convert.ToDateTime(Timelabel.Text);
                    pos.Cashiername = CashiertextBox.Text;
                    pos.Customerid = IdtextBox.Text;
                    pos.ItemName = ItemNametextBox.Text;
                    pos.ItemPrice = float.Parse(ItemPricetextBox.Text);
                    pos.ItemQuentity = int.Parse(ItemQuantitytextBox.Text);
                    pos.TotalPrice = float.Parse(TotalPricetextBox.Text);
                    pos.Vat = Convert.ToInt32(VattextBox.Text);
                    pos.TotalPayment = Convert.ToSingle(TotalPaymenttextBox.Text);
                    pos.BkashPayment = PaymentTypecomboBox.Text = "bkash";
                   pos.PaidAmount = Convert.ToSingle(PaidAmounttextBox.Text);
                    pos.ReturnAmount = float.Parse(ReturnedAmounttextBox.Text);
                    int flag = poswindow.addpayment(pos);
                    if (flag > 0)
                    {
                        MessageBox.Show("Item Data Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
               DataTable dataTable = poswindow.dataview(ItemNametextBox.Text);
               dataGridView1.DataSource = dataTable;
            }
        }

       
        private void Confirmtbutton_Click(object sender, EventArgs e)
        {
          if(TotalPaytextBox.Text==string.Empty||VattextBox.Text==string.Empty||WithvatTotaltextBox.Text==string.Empty||TotalPaymenttextBox.Text==string.Empty)
           {
           MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
             else if(PaymentTypecomboBox.Text==string.Empty)
            {
               MessageBox.Show("Please Select Payment Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(double.Parse(TotalPaymenttextBox.Text)>double.Parse(PaidAmounttextBox.Text))
            {
                   MessageBox.Show("Payment is low");
           }
          else if(IdtextBox.Text==string.Empty)
          {
                MessageBox.Show("Please Confirm Customer Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           else
            {
                listBox.Items.Add("Date: " + Timelabel.Text);
                listBox.Items.Add("Cashier Name:" + CashiertextBox.Text);
                listBox.Items.Add("Customer Id: " + IdtextBox.Text);
                if(ItemNametextBox.Text!=string.Empty&&ItemPricetextBox.Text!=string.Empty&&ItemQuantitytextBox.Text!=string.Empty)
                {
                    listBox.Items.Add("Item Name: " + ItemNametextBox.Text);
                    listBox.Items.Add("Item Price: " + ItemPricetextBox.Text + "Tk");
                    listBox.Items.Add("Item Quantity: " + ItemQuantitytextBox.Text+"Tk");
                }
                listBox.Items.Add("Total Payment: " + TotalPaytextBox.Text + "Tk");
                listBox.Items.Add("Vat: " + VattextBox.Text + "%");
                listBox.Items.Add("Net Total: " + TotalPaymenttextBox.Text + "Tk");
                if(PaymentTypecomboBox.Text=="cash")
                {
                    listBox.Items.Add("Payment Type: " + PaymentTypecomboBox.Text);
                    listBox.Items.Add("Paid Amount: " + PaidAmounttextBox.Text);
                    listBox.Items.Add("Return Amount: " + ReturnedAmounttextBox.Text);
                }
                listBox.Items.Add("..........................");
                

                }
             MessageBox.Show("Order confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ItemQuantitytextBox_TextChanged(object sender, EventArgs e)
        {
            if(ItemQuantitytextBox.Text==string.Empty)
            {
                TotalPricetextBox.Text = "";
            }
            else
            {
                TotalPricetextBox.Text = (float.Parse(ItemPricetextBox.Text) * int.Parse(ItemQuantitytextBox.Text)).ToString();
                pos.TotalPrice = float.Parse(TotalPricetextBox.Text);
                TotalPaytextBox.Text = TotalPricetextBox.Text;
            }
           
        }

        private void ItemQuantitytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void VattextBox_TextChanged(object sender, EventArgs e)
        {
            if(VattextBox.Text==string.Empty)
            {
                WithvatTotaltextBox.Text = "";
            }
            else
            {
                sum();
            }          

        }
        void sum()
        {
            try
            {
                double cal = ((Convert.ToSingle(VattextBox.Text) * Convert.ToSingle(TotalPaytextBox.Text)) / 100);
                double calculate = cal + Convert.ToSingle(TotalPaytextBox.Text);
                WithvatTotaltextBox.Text = calculate.ToString();
                TotalPaymenttextBox.Text = Math.Round(calculate).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
                     
        }

        private void ItemPricetextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemPricetextBox.Text == string.Empty)
            {
                ItemQuantitytextBox.Text = "";
                TotalPricetextBox.Text = "";
                TotalPaytextBox.Text = "";
            }
        }

        private void VattextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false&&e.KeyChar!='.'&&char.IsWhiteSpace(e.KeyChar)==false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalPricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PaymentTypecomboBox.Text=="cash")
            {
                PaidAmountlabel.Visible = true;
                PaidAmounttextBox.Visible = true;
                ReturnedAmountlabel.Visible = true;
                ReturnedAmounttextBox.Visible = true;
            }
          
        }

        private void PaidAmounttextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PaidAmounttextBox.Text == string.Empty)
                {
                    ReturnedAmounttextBox.Text = "";
                }
             
                else 
                {
                    ReturnedAmounttextBox.Text = (double.Parse(PaidAmounttextBox.Text) - double.Parse(TotalPaymenttextBox.Text)).ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
           
        }

        private void ItemPricetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaidAmounttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemtextBox_TextChanged(object sender, EventArgs e)
        {
            information();

        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            DataTable dataTable = poswindow.alldata();
            dataGridView1.DataSource = dataTable;
            int sum = 0;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells["totalprice"].Value.ToString());
            }
            TotalPaytextBox.Text = sum.ToString();
           
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            ItemNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["itemname"].Value.ToString();
            ItemPricetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["itemprice"].Value.ToString();
            ItemQuantitytextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["itemquantity"].Value.ToString();
            TotalPricetextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["totalprice"].Value.ToString();
            VattextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["vat"].Value.ToString();
            PaymentTypecomboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["paymenttype"].Value.ToString();
            PaidAmounttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["paidamount"].Value.ToString();
            ReturnedAmounttextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["returnamount"].Value.ToString();
            TotalPaytextBox.Text = TotalPricetextBox.Text;

        }

        public void clearinformation()
        {
            ItemtextBox.Text = "";
            ItemNametextBox.Text = "";
            IdtextBox.Text = "";
            ItemPricetextBox.Text = "";
            ItemQuantitytextBox.Text = "";
            TotalPricetextBox.Text = "";
            TotalPaytextBox.Text = "";
            VattextBox.Text = "";
            WithvatTotaltextBox.Text = "";
            TotalPaymenttextBox.Text = "";
            PaymentTypecomboBox.Text = "";
            PaidAmounttextBox.Text = "";
            PaidAmounttextBox.Text = "";
            ItemtextBox.Focus();
        }
        private void Clearbutton_Click(object sender, EventArgs e)
        {
            clearinformation();
        }

        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && e.KeyChar != '.' && char.IsWhiteSpace(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
