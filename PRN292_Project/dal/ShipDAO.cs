using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PRN292_Project.dal
{
    public class ShipDAO : DBContext
    {
       public DataTable getShip()
        {
            String sql = "SELECT * from Ship";
            return GetDataBySQL(sql);
        }

    }
}