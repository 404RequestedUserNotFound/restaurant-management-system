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
    public class PoswindowInformation
    {
        public DataBaseConnection connection;
        public DataTable dataTable;
        int flag,flag1;
        public int add(PosWindow poswindow)
        {
            try
            {
                connection = new DataBaseConnection();
                if(poswindow.CashPayment=="cash")
                {
                    string query = "Insert into PosInformation(date,cashiername,customerid,itemname,itemprice,itemquantity,totalprice,vat,totalpayment,paymenttype,paidamount,returnamount) values('" + poswindow.SaleDate + "','" + poswindow.Cashiername + "','" + poswindow.Customerid + "','" + poswindow.ItemName + "','" + poswindow.ItemPrice + "','" + poswindow.ItemQuentity + "','" + poswindow.TotalPrice + "','" + poswindow.Vat + "','" + poswindow.TotalPayment + "','" + poswindow.CashPayment + "','" + poswindow.PaidAmount + "','" + poswindow.ReturnAmount + "')";
                    flag = connection.ExecuteQuery(query);  
                }
                connection.closeconnection();
                return flag;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }

        }
        public int addpayment(PosWindow poswindow)
        {
            try
            {
                connection = new DataBaseConnection();
                if (poswindow.CashPayment == "bkash")
                {
                    string query = "Insert into PosInformation(date,cashiername,customerid,itemname,itemprice,itemquantity,totalprice,vat,totalpayment,paymenttype,paidamount,returnamount) values('" + poswindow.SaleDate + "','" + poswindow.Cashiername + "','" + poswindow.Customerid + "','" + poswindow.ItemName + "','" + poswindow.ItemPrice + "','" + poswindow.ItemQuentity + "','" + poswindow.TotalPrice + "','" + poswindow.Vat + "','" + poswindow.TotalPayment + "','" + poswindow.BkashPayment + "'";//,'" + poswindow.PaidAmount + "','" + poswindow.ReturnAmount + "')";
                    flag1 = connection.ExecuteQuery(query);
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

        public DataTable dataview(string itemname)
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PosInformation where itemname='"+itemname+"'";
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
        public DataTable search(string itemname)
        {
            try
            {
                connection = new DataBaseConnection();
              

                    string sql = "Select * from PosInformation where itemname='" + itemname + "'";
                    dataTable = connection.GetDataTable(sql);
                
                connection.closeconnection();
                return dataTable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public DataTable alldata()
        {
            try
            {
                connection = new DataBaseConnection();
                string query = "Select * from PosInformation";
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
