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
    public class CustoInfo
    {
        public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1, flag2;
        public int insertcustomer(Cus cus)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into CustomerInformation(customername,customerid,customeraddress,customercontact)values('" + cus.CustomerName + "','" + cus.CustomerId + "','" + cus.CustomerAddress + "','" + cus.CustomerContactNo + "')";
               
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
        public int updatecustomer(Cus cus)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customername='" + cus.CustomerName + "'or customerid='" + cus.CustomerId + "'or customeraddress='" + cus.CustomerAddress + "'or customercontact='" + cus.CustomerContactNo + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Update CustomerInformation set customername='" + cus.CustomerName + "', customerid='" + cus.CustomerId + "', customeraddress='" + cus.CustomerAddress + "', customercontact='" + cus.CustomerContactNo + "'where customername='" + cus.CustomerName + "'or customerid='" + cus.CustomerId + "'or customeraddress='" + cus.CustomerAddress + "'or customercontact='" + cus.CustomerContactNo + "'";
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
        public int deletecustomer(Cus cus)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customername='" + cus.CustomerName + "'or customerid='" + cus.CustomerId + "'or customeraddress='" + cus.CustomerAddress + "'or customercontact='" + cus.CustomerContactNo + "'";
                
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Delete from CustomerInformation where customername='" + cus.CustomerName + "'or customerid='" + cus.CustomerId + "'or customeraddress='" + cus.CustomerAddress + "'or customercontact='" + cus.CustomerContactNo + "'";
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
        public DataTable searchcustomer(string id)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customerid='" + id + "'";//customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContactNo + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {

                    string sql = "Select * from CustomerInformation where customerid='" + id + "'";
                    sqlDataReader.Close();
                    dataTable = connection.GetDataTable(sql);
                   
                   
                    MessageBox.Show("Customer Search Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
                string query = "Select * from CustomerInformation";
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

    }
}
