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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BookDAO.getSearch();
            string name = dt.Rows[1]["Result"].ToString();
            if(name.Equals("Kinh điển"))
            {
                Label3.Text = "Kinh điển";
                DataList2.DataSource = BookDAO.getClassicBooks();
                DataList2.DataBind();
                Label4.Visible = false;
                BookDAO.UpdateSearch2("Home");
            }
            else if(name.Equals("Văn học"))
            {
                Label3.Text = "Văn học";
                DataList2.DataSource = BookDAO.getLiteratureBooks();
                DataList2.DataBind();
                Label4.Visible = false;
                BookDAO.UpdateSearch2("Home");
            }
            else if (name.Equals("Trinh thám"))
            {
                Label3.Text = "Trinh thám";
                DataList2.DataSource = BookDAO.getMysteryBooks();
                DataList2.DataBind();
                Label4.Visible = false;
                BookDAO.UpdateSearch2("Home");
            }
            else if (name.Equals("Lãng mạn"))
            {
                Label3.Text = "Lãng mạn";
                DataList2.DataSource = BookDAO.getRomanceBooks();
                DataList2.DataBind();
                Label4.Visible = false;
                BookDAO.UpdateSearch2("Home");
            }
            else if (name.Equals("Kỹ năng sống"))
            {
                Label3.Text = "Kỹ năng sống";
                DataList2.DataSource = BookDAO.getLifeStyleBooks();
                DataList2.DataBind();
                Label4.Visible = false;
                BookDAO.UpdateSearch2("Home");
            }
            else if (name.Equals("Home"))
            {
                Label3.Text = "Bán chạy";
                DataList2.DataSource = BookDAO.getMostBoughtBooks();
                DataList2.DataBind();
                Label4.Visible = true;
                Label4.Text = "Mới nhất";
                DataList4.DataSource = BookDAO.getNewestBooks();
                DataList4.DataBind();
            }
        }

        public void LoadData()
        {
            DataList2.DataSource = BookDAO.getMostBoughtBooks();
            DataList2.DataBind();
            DataList4.DataSource = BookDAO.getNewestBooks();
            DataList4.DataBind();            
        }
    }

}