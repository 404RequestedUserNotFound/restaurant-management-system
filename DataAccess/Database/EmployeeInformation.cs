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
    public class EmployeeInformation
    {
        public DataBaseConnection connection;
       
        public DataTable dataTable;
        public int flag1, flag2;

        public DataTable Dataview()
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from EmployeeInformation";

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
        public int insertemployee(Employee employee)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Insert into EmployeeInformation(Employeename,Employeeid,Employeesalary,Employeecategory)values('" + employee.Employeename + "','" + employee.Employeeid + "','" + employee.Employeesalary + "','" + employee.Employeecategory + "')";
               
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

        public int updateemployee(Employee employee)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from EmployeeInformation where Employeename ='" + employee.Employeename + "'or Employeeid='" + employee.Employeeid + "'or Employeesalary='" + employee.Employeesalary + "'or Employeecategory='" + employee.Employeecategory + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Update EmployeeInformation set Employeename='" + employee.Employeename + "', Employeeid='" + employee.Employeeid + "', Employeesalary='" + employee.Employeesalary + "', Employeecategory='" + employee.Employeecategory + "'where Employeename='" + employee.Employeename + "'or Employeeid='" + employee.Employeeid + "'or Employeesalary='" + employee.Employeesalary + "'or Employeecategory='" + employee.Employeecategory + "'";
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

        public int deleteemployee(Employee employee)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from EmployeeInformation where Employeename='" + employee.Employeename + "'or Employeeid='" + employee.Employeeid + "'or Employeesalary='" + employee.Employeesalary + "'or Employeecategory='" + employee.Employeecategory + "'";
              
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {
                    string sql = "Delete from EmployeeInformation where Employeename='" + employee.Employeename + "'or Employeeid='" + employee.Employeeid + "'or Employeesalary='" + employee.Employeesalary + "'or Employeecategory='" + employee.Employeecategory + "'";
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
        public DataTable searchemployee(string id)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from EmployeeInformation where Employeeid='" + id + "'";//customername='" + customer.CustomerName + "'or customerid='" + customer.CustomerId + "'or customeraddress='" + customer.CustomerAddress + "'or customercontact='" + customer.CustomerContactNo + "'";
               
                SqlDataReader sqlDataReader = connection.Readdata(query);
                if (sqlDataReader.Read() == true)
                {

                    string sql = "Select * from EmployeeInformation where Employeeid='" + id + "'";
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

    }
}
