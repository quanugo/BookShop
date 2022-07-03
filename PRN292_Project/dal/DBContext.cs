using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PRN292_Project

{
    public class DBContext
    {
        internal static SqlConnection connection;
        public static SqlConnection GetConnection()
        {
            string ConString = ConfigurationManager.ConnectionStrings["BookStr"].ToString();
            connection = new SqlConnection(ConString);
            return connection;
        }

        //thuc thi cau sql, voi ds cac tham so Parameters
        public static int ExecuteSQL(string sql, params SqlParameter[] Parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(Parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }

        public static DataTable GetDataBySQL(string sql, params SqlParameter[] Parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(Parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }




        public static int DeleteStudent(string StudentID)
        {
            //xoa cac order details lien quan toi khach hang CustomerID
            string sql = "delete from Students where StudentID = @sid"; //subquery lay ve cac order cua khach hang customerid
            SqlParameter param1 = new SqlParameter("@sid", SqlDbType.VarChar);
            param1.Value = StudentID;
            int count = ExecuteSQL(sql, param1);
            return count;
        }
    }
}
