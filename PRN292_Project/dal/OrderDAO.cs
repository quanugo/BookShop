using PRN292_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRN292_Project.dal
{
    public class OrderDAO : DBContext
    {
        public static DataTable getOrder(string orderid)
        {
            if (orderid == "")
            {
                string sql = "select [Order].OrderID, Email, [User].[Address],OrderDate, [Status].Name as " +
                    "[Status] from[Order], [User], [Status] where [User].UserID = [Order].UserID and[Status].StatusID = [Order].StatusID";

                return GetDataBySQL(sql);
            }
            else
            {
                string sql = "select [Order].OrderID, Email, [User].[Address],OrderDate, [Status].Name as [Status] from[Order], [User], [Status] where [User].UserID = [Order].UserID and[Status].StatusID = [Order].StatusID and [Order].OrderID = @orderid";
                SqlParameter param2 = new SqlParameter("@orderid", SqlDbType.Int);
                param2.Value = orderid;
                return GetDataBySQL(sql, param2);
            }


        }
        public static int insertOrder(DateTime orderDate, DateTime shippedDate, int ShipID, string Address, int StatusID, int User)
        {
            string sql = "insert into [Order] " +
               "(OrderDate, ShippedDate, ShipID, Address, StatusID, UserID)" +
               "values(@orddate, @shipdate, @shipid, @address, @statusID, @userID)";
            SqlParameter param1 = new SqlParameter("orddate", System.Data.SqlDbType.Date);
            param1.Value = orderDate;
            SqlParameter param2 = new SqlParameter("shippedDate", System.Data.SqlDbType.Date);
            param2.Value = shippedDate;
            SqlParameter param3 = new SqlParameter("shipid", System.Data.SqlDbType.Int);
            param3.Value = ShipID;
            SqlParameter param4 = new SqlParameter("address", System.Data.SqlDbType.NVarChar);
            param4.Value = Address;
            SqlParameter param5 = new SqlParameter("statusID", System.Data.SqlDbType.Int);
            param5.Value = StatusID;
            SqlParameter param6 = new SqlParameter("userID", System.Data.SqlDbType.Int);
            param6.Value = User;
            return ExecuteSQL(sql, param1, param2, param3, param4, param5, param6);
        }
        public static List<Order> GetAllOrderFromDataTable(DataTable dt)
        {
            List<Order> list = new List<Order>();
            foreach (DataRow dr in dt.Rows)
            {
                int k = 0;
                try
                {
                    k = Convert.ToInt32(dr["OrderID"]);
                }
                catch
                { }
                Order c = new Order(k,
                        dr["Email"].ToString(),
                        dr["Address"].ToString(),
                        Convert.ToDateTime(dr["OrderDate"].ToString()),
                        dr["Status"].ToString());
                list.Add(c);
            }
            return list;
        }
        public static List<Order> GetAllOrderByUserName(string orderid)
        {
            DataTable dt = getOrder(orderid);
            return GetAllOrderFromDataTable(dt);
        }
    }
}