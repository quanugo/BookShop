using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PRN292_Project.dal;

namespace PRN292_Project
{
    public partial class HomePage2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            BookDAO.UpdateSearch(name);
            Response.Redirect("searchresult.aspx", false);
        }

        protected void btnKinhdien_Click(object sender, EventArgs e)
        {
            BookDAO.UpdateSearch2("Kinh điển");
            Response.Redirect("home.aspx", false);
        }

        protected void btnVanhoc_Click(object sender, EventArgs e)
        {
            BookDAO.UpdateSearch2("Văn học");
            Response.Redirect("home.aspx", false);
        }

        protected void btnTrinhtham_Click(object sender, EventArgs e)
        {
            BookDAO.UpdateSearch2("Trinh thám");
            Response.Redirect("home.aspx", false);
        }

        protected void btnLangman_Click(object sender, EventArgs e)
        {
            BookDAO.UpdateSearch2("Lãng mạn");
            Response.Redirect("home.aspx", false);
        }

        protected void btnKynangsong_Click(object sender, EventArgs e)
        {
            BookDAO.UpdateSearch2("Kỹ năng sống");
            Response.Redirect("home.aspx", false);
        }

        
    }
}