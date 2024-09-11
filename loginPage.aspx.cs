using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CVBlog
{
    public partial class loginPage : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5ANGUIR\\SQLEXPRESS02;Initial Catalog=CVBLOG;Integrated Security=True;Encrypt=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select *from ADMIN where USERNAME=@u AND PASSWORD=@p",conn);
            cmd.Parameters.AddWithValue("@u", txtUserName.Text);
            cmd.Parameters.AddWithValue("@p", txtPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("adminAbout.aspx");
            }
            else
            {
                Response.Write("Wrong username or password!");
            }
            conn.Close();
        }
    }
}