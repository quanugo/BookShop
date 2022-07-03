using PRN292_Project.dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRN292_Project
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BookStr"].ToString());
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = txtUser.Text;
                string pass = txtPass.Text;
                con.Open();
                string qry = "select Email, Password from [User] where Email='" + uid + "' and Password='" + pass + "'";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Response.Redirect("home.aspx");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}