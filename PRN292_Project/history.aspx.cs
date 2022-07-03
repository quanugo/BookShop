using PRN292_Project.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_Project
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadData();
        }

        void LoadData()
        {
            string orderid = "";
            try
            {
                orderid = tbFind.Text.Trim();
            }
            catch (System.FormatException)
            {
                orderid = ""; // or other default value as appropriate in context.
            }
            gvOrder.DataSource = OrderDAO.GetAllOrderByUserName(orderid);
            gvOrder.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}