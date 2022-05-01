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
    public class CustomerInformation
    {
        public DataBaseConnection connection;
        public DataTable dataTable;
        public int flag1, flag2;
        public int insertcustomer(Customer customer)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into CustomerInformation(customername,customerid,customeraddress,customercontact)values('" + customer.CustomerName + "','" + customer.CustomerId + "','" + customer.CustomerAddress + "','" + customer.CustomerContact + "')";
                int flag = connection.ExecuteQuery(query);
                connection.closeconnection();
                return flag;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        public int updatecustomer(Customer customer)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContact + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
                    string sql = "Update CustomerInformation set customername='" + customer.CustomerName + "', customerid='" + customer.CustomerId + "', customeraddress='" + customer.CustomerAddress + "', customercontact='" + customer.CustomerContact + "'where customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContact + "'";
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
        public int deletecustomer(Customer customer)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContact + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
                    string sql = "Delete from CustomerInformation where customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContact + "'";
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
        public DataTable searchcustomer(string id)
        {
            try
            {
                connection = new DataBaseConnection();
               string query = "Select * from CustomerInformation where customerid='" + id + "'";
                SqlDataReader reader = connection.Readdata(query);
                if (reader.Read() == true)
                {
              
                   string sql = "Select * from CustomerInformation where customerid='" + id + "'";
                    reader.Close();
                    dataTable = connection.GetDataTable(sql);
                    MessageBox.Show("Customer Search Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
               {
                MessageBox.Show("Customer data not found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                connection.closeconnection();
                return dataTable;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable dataview(string customername, string customerid, string customeraddress, string customercontact)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation where customername='" + customername + "'and customerid='" + customerid + "'and customeraddress='" + customeraddress + "'and customercontact='" + customercontact + "'";
                DataTable dataTable = connection.GetDataTable(query);

                connection.closeconnection();
                return dataTable;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public List<Customer> custonerlist()
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from CustomerInformation";
                SqlDataReader reader = connection.Readdata(query);
                List<Customer> customers = new List<Customer>();
                
                while (reader.Read())
                {
                    Customer customer = new Customer();
                    customer.CustomerName = reader["customername"].ToString();
                    customer.CustomerId = reader["customerid"].ToString();
                    customer.CustomerAddress = reader["customeraddress"].ToString();
                    customer.CustomerContact = reader["customercontact"].ToString();
                    customers.Add(customer);


                }
                connection.closeconnection();
                return customers;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

    }
}
