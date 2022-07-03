using PRN292_Project.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_Project
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string BookID = (Request.QueryString["bid"] != null) ? Request.QueryString["bid"].ToString() : "Chua co sach";
            int ID = Convert.ToInt32(BookID);
            DataTable db = BookDAO.getBookByID(ID);
            string imgPath = db.Rows[0]["imagePath"].ToString();
            Image1.ImageUrl = imgPath;
            Name.Text = db.Rows[0]["BookName"].ToString();
            Price.Text = db.Rows[0]["Price"].ToString();
            Author.Text = db.Rows[0]["Author"].ToString();
            Publisher.Text = db.Rows[0]["Publisher"].ToString();
            Genre.Text = db.Rows[0]["Genre"].ToString();
            Description.Text = db.Rows[0]["Description"].ToString();
        }
    }
}