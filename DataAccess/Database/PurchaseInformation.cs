using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.Database
{
    public class PurchaseInformation
    {
        public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1,flag2;

        public int addpurchase(Purchase purchase)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into PurchaseInformation(date,itemname,customername,customerid,quantity,price,totalprice) values ('" + purchase.Date + "','" + purchase.ItemName + "','" + purchase.CustomerName + "','" + purchase.CustomerId + "','" + purchase.Quantity + "','" + purchase.Price + "','"+purchase.TotalPrice+"')";
                int flag=connection.ExecuteQuery(query);
                connection.closeconnection();
                return flag;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int removepurchase(Purchase purchase)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PurchaseInformation where date='" + purchase.Date + "'or itemname='" + purchase.ItemName + "'or customername='" + purchase.CustomerName + "'or customerid='" + purchase.CustomerId + "'or quantity='" + purchase.Quantity + "'or price='" + purchase.Price + "'or totalprice='" + purchase.TotalPrice + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
                    string sql = "Delete from PurchaseInformation where date='" + purchase.Date + "'or itemname='" + purchase.ItemName + "'or customername='" + purchase.CustomerName + "'or customerid='" + purchase.CustomerId + "'or quantity='" + purchase.Quantity + "'or price='" + purchase.Price + "'or totalprice='" + purchase.TotalPrice + "'";
                    reader.Close();
                    flag2 = connection.ExecuteQuery(sql);

                }

                else
                {
                    MessageBox.Show("Please Correct information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.closeconnection();
                return flag2;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public int Editpurchase(Purchase purchase)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PurchaseInformation where date='" + purchase.Date + "'or itemname='" + purchase.ItemName + "'or customername='" + purchase.CustomerName + "'or customerid='" + purchase.CustomerId + "'or quantity='" + purchase.Quantity + "'or price='" + purchase.Price + "'or totalprice='" + purchase.TotalPrice + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
                    string sql = "Update PurchaseInformation set date='" + purchase.Date + "',itemname='" + purchase.ItemName + "',customername='" + purchase.CustomerName + "', customerid='" + purchase.CustomerId + "', quantity='" + purchase.Quantity + "', price='" + purchase.Price + "', totalprice='" + purchase.TotalPrice + "' where date='" + purchase.Date + "'or itemname='" + purchase.ItemName + "'or customername='" + purchase.CustomerName + "'or customerid='" + purchase.CustomerId + "'or quantity='" + purchase.Quantity + "'or price='" + purchase.Price + "'or totalprice='" + purchase.TotalPrice + "'";
                    reader.Close();
                    flag1 = connection.ExecuteQuery(sql);

                }
                else
                {
                    MessageBox.Show("Please Correct information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connection.closeconnection();
                return flag1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
        public DataTable searchpurchase(string name)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PurchaseInformation where itemname='" + name + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {

                    string sql = "Select * from PurchaseInformation where itemname='" + name + "'";
                    reader.Close();
                    dataTable = connection.GetDataTable(sql);
                    MessageBox.Show("Item  Search Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Item not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.closeconnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable dataview(string itemname)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PurchaseInformation where itemname='"+itemname+"'";
                dataTable = connection.GetDataTable(query);

                connection.closeconnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public List<Purchase> purchaselist()
        {
           
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PurchaseInformation";
                SqlDataReader reader = connection.Readdata(query);
                List<Purchase> purchases = new List<Purchase>();

                while (reader.Read())
                {
                    Purchase purchase = new Purchase();
                    purchase.Date = Convert.ToDateTime(reader["date"].ToString());
                    purchase.ItemName = reader["itemname"].ToString();
                    purchase.CustomerName = reader["customername"].ToString();
                    purchase.CustomerId = reader["customerid"].ToString();
                    purchase.Quantity = Convert.ToInt32(reader["quantity"]);
                    purchase.Price = Convert.ToSingle(reader["price"]);
                   
                    purchase.TotalPrice = Convert.ToSingle(reader["totalprice"]);
                   
                    purchases.Add(purchase);


                }
                connection.closeconnection();
                return purchases;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
