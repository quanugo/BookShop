using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PRN292_Project.Entity;

namespace PRN292_Project.dal
{
    public class BookDAO : DBContext
    {
        //public static DataTable getMostBoughtBooks()
        //{
        //    string sql = "with S as(" +
        //        "select top 8 BookID,Sum(Quantity)[Total_Quan] " +
        //        "FROM Order_Book" +
        //        " Group by BookID" +
        //        " order by(Total_Quan) desc ) " +
        //        "select* " +
        //        "from Book B, S " +
        //        "where B.BookID = S.BookID";
        //    return GetDataBySQL(sql);

        //}
        public static DataTable getNewestBooks()
        {
            string sql = "select top 8 * from Book order by (PublishedDate) desc";
            return GetDataBySQL(sql);

        }

        public static DataTable getClassicBooks()
        {
            string sql = "select * from Book where Genre = N'Kinh điển'";
            return GetDataBySQL(sql);

        }

        public static DataTable getRomanceBooks()
        {
            string sql = "select * from Book where Genre = N'Lãng mạn'";
            return GetDataBySQL(sql);

        }

        public static DataTable getLiteratureBooks()
        {
            string sql = "select * from Book where Genre = N'Văn học'";
            return GetDataBySQL(sql);

        }

        public static DataTable getMysteryBooks()
        {
            string sql = "select * from Book where Genre = N'Trinh thám'";
            return GetDataBySQL(sql);

        }

        public static DataTable getLifeStyleBooks()
        {
            string sql = "select * from Book where Genre = N'Kỹ năng sống'";
            return GetDataBySQL(sql);

        }

        public static DataTable getSearch()
        {
            string sql = "select * from [Search1]";
            return GetDataBySQL(sql);
        }
        public static DataTable getAll(string name)
        {
            string sql = "";
            if (name == null)
            {
                return GetDataBySQL(sql);
            }
            else
            {
                sql = "SELECT * from Book where BookName LIKE @name ";
                SqlParameter param = new SqlParameter("@name", SqlDbType.NVarChar);
                param.Value = "%" + name + "%";
                return GetDataBySQL(sql, param);              
            }
        }

        public static int UpdateSearch(string name)
        {
            string sql = "update Search1 set Result = @name where ID = 1";

            SqlParameter param0 = new SqlParameter("name", System.Data.SqlDbType.NVarChar);
            param0.Value = name;
            return ExecuteSQL(sql, param0);
        }

        public static int UpdateSearch2(string name)
        {
            string sql = "update Search1 set Result = @name where ID = 2";

            SqlParameter param0 = new SqlParameter("name", System.Data.SqlDbType.NVarChar);
            param0.Value = name;
            return ExecuteSQL(sql, param0);
        }


        public static DataTable getMostBoughtBooks(int id)
        {
            string sql = "select  * from Book where BookID = @book";
            SqlParameter param2 = new SqlParameter("@book", SqlDbType.Int);
            param2.Value = id;
            return GetDataBySQL(sql);
        }

        public static List<Book> GetAllBookFromDataTable(DataTable dt)
        {
            List<Book> list = new List<Book>();
            foreach (DataRow dr in dt.Rows)
            {
                int k = 0;
                try
                {
                    k = Convert.ToInt32(dr["BookID"]);
                }
                catch
                { }
                Book c = new Book(k,
                        dr["BookName"].ToString(),
                        dr["Author"].ToString(),
                        dr["Publisher"].ToString(),
                        Convert.ToDateTime(dr["PublishedDate"].ToString()),
                        Convert.ToDouble(dr["Price"].ToString()),
                        dr["Genre"].ToString(),
                        dr["Description"].ToString(),
                        dr["ImagePath"].ToString());
                list.Add(c);
            }
            return list;
        }
        public static List<Book> GetAllBookByID(int id)
        {
            DataTable dt = getMostBoughtBooks(id);
            return GetAllBookFromDataTable(dt);
        }

        public static DataTable getMostBoughtBooks()
        {
            string sql = "with S as(" +
                "select top 8 BookID,Sum(Quantity)[Total_Quan] " +
                "FROM Order_Book" +
                " Group by BookID" +
                " order by(Total_Quan) desc ) " +
                "select* " +
                "from Book B, S " +
                "where B.BookID = S.BookID";
            return GetDataBySQL(sql);

        }

        public static DataTable getBookByID(int ID)
        {
            string sql = "select * from Book where BookID = @bid";
            SqlParameter param = new SqlParameter("@bid", SqlDbType.Int);
            param.Value = ID;
            return GetDataBySQL(sql, param);


        }
    }
}