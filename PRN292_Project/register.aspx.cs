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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["BookStr"].ToString());
        protected void SignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbEmail.Text;
                DateTime dob = Convert.ToDateTime(tbDOB.Text);
                string phone = tbPhone.Text;
                string address = tbAddress.Text;
                string password = tbPass.Text;
                con.Open();
                string sql = "insert into [User] (Email, DOB, Phone, Address, Password) values(@email,@dob,@phone,@address,@password)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("email", username);
                cmd.Parameters.AddWithValue("dob", tbDOB.Text);
                cmd.Parameters.AddWithValue("phone", phone);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("password", password);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}