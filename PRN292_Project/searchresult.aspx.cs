using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PRN292_Project.dal;

namespace PRN292_Project
{
    public partial class searchresult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BookDAO.getSearch();
            string name = dt.Rows[0]["Result"].ToString();
            DataList2.DataSource = BookDAO.getAll(name);
            DataList2.DataBind();           
        }
    }
}