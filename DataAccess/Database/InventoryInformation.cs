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
    public class InventoryInformation
    {
       public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1, flag2;
        public int insertinventory(Inventory inventory)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into InventoryInformation(inventoryid,productname,quantity)values('" + inventory.Inventoryid + "','" + inventory.ProductName + "','" + inventory.Quantity + "')";
                int flag=connection.ExecuteQuery(query);
                connection.closeconnection();
                return flag;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        public int updateinventory(Inventory inventory)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from InventoryInformation where inventoryid='" + inventory.Inventoryid + "'or productname='" + inventory.ProductName + "'or quantity='" + inventory.Quantity + "'";
               SqlDataReader reader = connection.Readdata(query);

                if (reader.Read() == true)
                {
                    string sql = "Update InventoryInformation set inventoryid='" + inventory.Inventoryid + "', productname='" + inventory.ProductName + "', quantity='" + inventory.Quantity + "'where inventoryid='" + inventory.Inventoryid + "'or productname='" + inventory.ProductName + "'or quantity='" + inventory.Quantity + "'";
                    reader.Close();
                    flag1= connection.ExecuteQuery(sql);

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
        public int deleteinventory(Inventory inventory)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from InventoryInformation where inventoryid='" + inventory.Inventoryid + "'or productname='" + inventory.ProductName + "'or quantity='" + inventory.Quantity + "'";
                SqlDataReader reader = connection.Readdata(query);

                if (reader.Read() == true)
                {
                   string sql = "Delete from InventoryInformation where inventoryid='" + inventory.Inventoryid + "'or productname='" + inventory.ProductName + "'or quantity='" + inventory.Quantity + "'";
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
        public DataTable searchinventory(string id)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from InventoryInformation where inventoryid='" + id + "'";
                SqlDataReader reader = connection.Readdata(query);

                if (reader.Read() == true)
                {

                    string sql = "Select * from InventoryInformation where inventoryid='" + id + "'";
                    reader.Close();
                    dataTable = connection.GetDataTable(sql);

                   
                    MessageBox.Show("Inventory found Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Inventory data not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public DataTable dataview(string id, string productname, int quantity)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from InventoryInformation where inventoryid='" + id + "'and productname='" + productname + "'and quantity='" + quantity + "'";
                DataTable dataTable = connection.GetDataTable(query);
               
                connection.closeconnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<Inventory> inventorylist()
        {

            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from InventoryInformation ";
               SqlDataReader reader= connection.Readdata(query);
                List<Inventory> inventories = new List<Inventory>();

                while (reader.Read())
                {
                    Inventory inventory = new Inventory();

                    inventory.Inventoryid = reader["inventoryid"].ToString();
                    inventory.ProductName = reader["productname"].ToString();
                    inventory.Quantity = Convert.ToInt32(reader["quantity"]);
                    inventories.Add(inventory);
                }


                connection.closeconnection();
                return inventories;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }



    }
}
