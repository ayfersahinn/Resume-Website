using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminHobbyUpdate : System.Web.UI.Page
    {
        DataSet1TableAdapters.HOBBYTableAdapter dt = new DataSet1TableAdapters.HOBBYTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                txtID.Text = id.ToString();
                txtID.Enabled = false;

                txtHobby.Text = dt.getHobby(Convert.ToInt16(id))[0].HOBBY;
            }
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dt.hobbyUpdate(txtHobby.Text,Convert.ToInt16( txtID.Text));
            Response.Redirect("adminHobby.aspx");
        }
    }
}