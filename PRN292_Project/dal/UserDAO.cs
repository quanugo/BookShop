using PRN292_Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PRN292_Project.dal
{
    public class UserDAO : DBContext
    {
        public User get(string username, string password)
        {
            string sql = "select Email, Password from [User] where Email = @email and Password = @pass";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add(new SqlParameter("@email", username));
            command.Parameters.Add(new SqlParameter("@pass", password));
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User u = new User();
                u.email = reader["Email"].ToString();
                u.password = reader["Password"].ToString();
                connection.Close();
                return u;
            }
            return null;
        }
        public static DataTable getUser(string email, string password)
        {
            string sql = "select Email, Password from [User] where Email = @email and Password = @pass";
            SqlParameter param = new SqlParameter("@email", SqlDbType.NVarChar);
            param.Value = email;
            SqlParameter param2 = new SqlParameter("@pass", SqlDbType.NVarChar);
            param2.Value = password;
            return GetDataBySQL(sql, param, param2);

        }
        

        public static int insertUser(string name, string email, DateTime dob, string phone, string address, string password)
        {
            string sql = "insert into [User] " +
               "(Name, Email, DOB, Phone, Address, Keyword)" +
               "values(@name, @email, @dob, @phone, @address, @password)";
            SqlParameter param1 = new SqlParameter("name", System.Data.SqlDbType.NVarChar);
            param1.Value = name;
            SqlParameter param2 = new SqlParameter("email", System.Data.SqlDbType.NVarChar);
            param2.Value = email;
            SqlParameter param3 = new SqlParameter("dob", System.Data.SqlDbType.Date);
            param3.Value = dob;
            SqlParameter param4 = new SqlParameter("phone", System.Data.SqlDbType.NVarChar);
            param4.Value = phone;
            SqlParameter param5 = new SqlParameter("address", System.Data.SqlDbType.NVarChar);
            param5.Value = address;
            SqlParameter param6 = new SqlParameter("password", System.Data.SqlDbType.NVarChar);
            param6.Value = password;
            return ExecuteSQL(sql, param1, param2, param3, param4, param5, param6);
        }

        public static List<User> GetAllUserFromDataTable(DataTable dt)
        {
            List<User> list = new List<User>();
            foreach (DataRow dr in dt.Rows)
            {
                User u = new User(
                        dr["Email"].ToString(),
                        dr["Password"].ToString());
                list.Add(u);
            }
            return list;
        }
        public static List<User> GetUserbyEmailandPass(string email, string password)
        {
            DataTable dt = getUser(email, password);
            return GetAllUserFromDataTable(dt);
        }
    }
}