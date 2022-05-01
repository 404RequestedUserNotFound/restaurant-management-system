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
    public partial class FoodForm : Form
    {
        FoodItem foodForm = new FoodItem();
        FoodItemInformation foodItemInformation = new FoodItemInformation();


        public FoodForm()
        {
            InitializeComponent();
        }
        private void FoodForm__FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public void information()
        {
            foodForm.Foodname = textBox1.Text;
            foodForm.FoodId = textBox2.Text;
            foodForm.Foodquantity = textBox3.Text;


        }
        public void clearinformation()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }



        private void FoodForm_Load(object sender, EventArgs e)
        {
            
        }

        private void AddFood_Click(object sender, EventArgs e)
        {
            information();
            if (foodForm.Foodname == string.Empty || foodForm.FoodId == string.Empty || foodForm.Foodquantity == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = foodItemInformation.insertfooditem(foodForm);
                if (flag > 0)
                {
                    MessageBox.Show("Food Item Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unsuccessfull to add food item", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = foodItemInformation.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }



        private void DeleteFood_Click(object sender, EventArgs e)
        {
            information();

            if (foodForm.Foodname == string.Empty || foodForm.FoodId == string.Empty || foodForm.Foodquantity == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = foodItemInformation.deletefooditem(foodForm);
                if (flag > 0)
                {
                    MessageBox.Show("Food item Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                DataTable dataTable = foodItemInformation.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }

        private void FoodSearch_Click(object sender, EventArgs e)
        {

            information();

            if (Foodsearchbox.Text == string.Empty)
            {
                MessageBox.Show("Please fill up the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DataTable dataTable = foodItemInformation.searchfooditem(Foodsearchbox.Text);
                dataGridView1.DataSource = dataTable;

            }

        }

        private void Showfood_Click(object sender, EventArgs e)
        {
            DataTable dataTable = foodItemInformation.dataview();
            dataGridView1.DataSource = dataTable;
            textBox4.Text = dataGridView1.Rows.Count.ToString();

        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Foodsearchbox.Text = textBox2.Text;
        }

        private void UpdateFood_Click(object sender, EventArgs e)
        {
            information();
            if (foodForm.Foodname == string.Empty || foodForm.FoodId == string.Empty || foodForm.Foodquantity == string.Empty)
            {
                MessageBox.Show("Please Fill up All the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int flag = foodItemInformation.updatefooditem(foodForm);
                if (flag > 0)
                {
                    MessageBox.Show("Food Item Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DataTable dataTable = foodItemInformation.dataview();
                dataGridView1.DataSource = dataTable;
            }
            clearinformation();
        }
    }

}
