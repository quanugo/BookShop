using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRN292_Project.Entity
{
    public class Order_Book
    {
        public int OrderID { get; set; }
        public int BookID { get; set; } 
        public int quantity { get; set; }
    }
}