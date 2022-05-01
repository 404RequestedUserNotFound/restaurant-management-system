using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Purchase
    {
        public string ItemName 
        { 
            get; 
            set; 
        }
        public string CustomerName
        {
            get;
            set;
        }
        public string CustomerId
        {
            get;
            set;
        }
        public int Quantity 
        { 
            get; 
            set; 
        }
        public float Price 
        { 
            get; 
            set; 
        }
        public DateTime Date 
        { 
            get; 
            set; 
        }
      
        public float TotalPrice
        { 
            get; 
            set; 
        }

    }
}
