using System;
using System.Data;

namespace PRN292_Project
{
    public class StatusDAO : DBContext
    {
        public DataTable getStatus()
        {
            String sql = "SELECT * from Status";
            return GetDataBySQL(sql);
        }

        

    }
}
