using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Inventory
    {
        public string Inventoryid 
        { 
            get;
            set; 
        }
        public string ProductName 
        { 
            get; 
            set; 
        }
        public int Quantity 
        { 
            get; 
            set; 
        }
     
    }
}
