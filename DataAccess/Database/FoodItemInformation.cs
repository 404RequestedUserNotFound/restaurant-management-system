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
    public class FoodItemInformation
    {


        public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1, flag2;

        public int insertfooditem(FoodItem foodItem)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into FoodItemInformation(Foodname,FoodId,Foodquantity)values('" + foodItem.Foodname + "','" + foodItem.FoodId + "','" + foodItem.Foodquantity + "')";
             
                int flag = connection.ExecuteQuery(query);
                connection.closeconnection();
                return flag;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        public int updatefooditem(FoodItem foodItem)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from FoodItemInformation where foodname='" + foodItem.Foodname + "'or foodid = '" + foodItem.FoodId + "'or foodquantity = '" + foodItem.Foodquantity + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Update FoodItemInformation set foodname='" + foodItem.Foodname + "', foodId='" + foodItem.FoodId + "', foodquantity='" + foodItem.Foodquantity + "'where foodname='" + foodItem.Foodname + "'or foodId='" + foodItem.FoodId + "' or foodquantity='" + foodItem.Foodquantity + "'";
                    sqlDataReader.Close();
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

        public int deletefooditem(FoodItem foodItem)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select* from  FoodItemInformation where foodname = '" + foodItem.Foodname + "'or foodid = '" + foodItem.FoodId + "'or foodquantity = '" + foodItem.Foodquantity + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Delete from FoodItemInformation where foodname='" + foodItem.Foodname + "'or foodid = '" + foodItem.FoodId + "'or foodquantity = '" + foodItem.Foodquantity + "'";
                    sqlDataReader.Close();
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

        public DataTable searchfooditem(string id)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from FoodItemInformation where foodid='" + id + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {

                    string sql = "Select * from FoodItemInformation where foodid='" + id + "'";
                    sqlDataReader.Close();
                    dataTable = connection.GetDataTable(sql);                  
                    MessageBox.Show("Food Item Search Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Cannot find data");
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
        public DataTable dataview()
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from FoodItemInformation";
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

    }
}

