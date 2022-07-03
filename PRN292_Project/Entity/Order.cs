using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PRN292_Project.Entity
{
    public class Order
    {
        public Order(int orderID, string email, string address, DateTime orderDate, string status)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            Address = address;
            Status = status;
            Email = email;
        }

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }

    }
}