using DataAccess.Database;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class InventoryForm : Form
    {
        Inventory inven = new Inventory();
        InventoryInformation inventory = new InventoryInformation();
      
        public InventoryForm()
        {
            InitializeComponent();
        }
        void information()
        {
            inven.Inventoryid = IdtextBox.Text;
            inven.ProductName = ProductNametextBox.Text;
          
  
        }
        void clearinformation()
        {
            IdtextBox.Text = "";
            ProductNametextBox.Text="";
            QuantitytextBox.Text = "0";
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {

            information();
            if (inven.Inventoryid == string.Empty || inven.ProductName == string.Empty||QuantitytextBox.Text==string.Empty)
                {
                    MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             

                else
                {
                
                inven.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                int flag = inventory.insertinventory(inven);
                    if (flag > 0)
                    {
                        MessageBox.Show("Product Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   DataTable dataTable = inventory.dataview(IdtextBox.Text,ProductNametextBox.Text,inven.Quantity);
                   dataGridView1.DataSource = dataTable;

                }
           
            clearinformation();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdtextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["inventoryid"].Value.ToString();
            ProductNametextBox.Text = dataGridView1.Rows[e.RowIndex].Cells["productname"].Value.ToString();
           QuantitytextBox.Text= dataGridView1.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            SearchtextBox.Text = IdtextBox.Text;
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {
            information();

            if (inven.Inventoryid == string.Empty || inven.ProductName == string.Empty||QuantitytextBox.Text==string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                inven.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                int flag = inventory.deleteinventory(inven);
                if (flag > 0)
                {
                    MessageBox.Show("Product Remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataTable dataTable = inventory.dataview(IdtextBox.Text, ProductNametextBox.Text, inven.Quantity);
                dataGridView1.DataSource = dataTable;

            }
            clearinformation();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            information();

            if (SearchtextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dataTable = inventory.searchinventory(SearchtextBox.Text);
                dataGridView1.DataSource = dataTable;

            }
            SearchtextBox.Text = string.Empty;
        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            information();
            if (inven.Inventoryid == string.Empty || inven.ProductName == string.Empty||QuantitytextBox.Text==string.Empty)
            { 
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                inven.Quantity = Convert.ToInt32(QuantitytextBox.Text);
                int flag = inventory.updateinventory(inven);
                if (flag > 0)
                {
                    MessageBox.Show("Product Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = inventory.dataview(IdtextBox.Text, ProductNametextBox.Text, inven.Quantity);
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }

        private void QuantitytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar)==false&&char.IsWhiteSpace(e.KeyChar)==false&&e.KeyChar!='.'&&char.IsControl(e.KeyChar)==false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inventorylistbutton_Click(object sender, EventArgs e)
        {
            List<Inventory> list = inventory.inventorylist();
            dataGridView1.DataSource = list;
            Totalinventorylabel.Visible = true;
            Totallabel.Visible = true;
            Totallabel.Text = dataGridView1.Rows.Count.ToString();
        }
        private void IdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsWhiteSpace(e.KeyChar) == false && e.KeyChar != '-' && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
    }
}
    

