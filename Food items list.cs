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
    public partial class Food_items_list : Form
    {
        public Food_items_list()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OperationFood operationsfood = new OperationFood();
            SqlDataAdapter sqlDataAdapter = operationsfood.Show();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ManagerFood entityfood = new ManagerFood();
            OperationFood operationsfood = new OperationFood();

            entityfood.Fooditems = comFood.Text;
            entityfood.Price = comPrize.Text;

            int flag = operationsfood.Insert(entityfood);
            if (flag > 0)
            {
                MessageBox.Show("successfully inserted");
            }
            else
            {
                MessageBox.Show("not inserted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ManagerFood entityfood = new ManagerFood();
            OperationFood operationsfood = new OperationFood();

            entityfood.Fooditems = comFood.Text;
            entityfood.Price = comPrize.Text;

            int flag = operationsfood.Update(entityfood);
            if (flag > 0)
            {
                MessageBox.Show("Successfully Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ManagerFood entityfood = new ManagerFood();
            OperationFood operationsfood = new OperationFood();

            entityfood.Fooditems = comFood.Text;
            entityfood.Price = comPrize.Text;

            int flag = operationsfood.Delete(entityfood);
            if (flag > 0)
            {
                MessageBox.Show("Successfully Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int number1 = Convert.ToInt32(txt1.Text);
            int number2 = Convert.ToInt32(txt2.Text);
            int number3 = Convert.ToInt32(txt3.Text);
            int result = Convert.ToInt32((number1 + number2 + number3) * 0.1);
            textBox1.Text = ("Total" + result);
        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txt1.Text);
            int number2 = Convert.ToInt32(txt2.Text);
            int number3 = Convert.ToInt32(txt3.Text);
            int result = number1 + number2 + number3;
            int result1 = Convert.ToInt32((number1 + number2 + number3) * 0.1);
            int result3 = result - result1;
            textBox2.Text = ("Total" + result3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(txt1.Text);
            int number2 = Convert.ToInt32(txt2.Text);
            int number3 = Convert.ToInt32(txt3.Text);
            int result = number1 + number2 + number3;
            txtResult.Text = ("Total" + result);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ManagerForm().Show();
            this.Hide();
        }
    }
}
