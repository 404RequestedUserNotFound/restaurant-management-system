using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class PosWindow
    { 

        public int Vat
        {
            get;
            set;
           
        }
        public string ItemName
        {
            get;
            set;
        }
        public float ItemPrice
        {
            get;
            set;
        }
        public int ItemQuentity
        {
            get;
            set;
        }
        public string Customerid
        {
            get;
            set;
        }
        public string Cashiername
        {
            get;
            set;
        }
        public float TotalPrice
        {
            get;
            set;
        }
        public float TotalPayment
        {
            get;
            set;
        }
        public float PaidAmount
        {
            get;
            set;
        }
        public float ReturnAmount
        {
            get;
            set;
        }
        public string CashPayment { get; set; }
        public string BkashPayment { get; set; }
        public DateTime SaleDate 
        { 
            get; 
            set; 
        }
      
    }
}
