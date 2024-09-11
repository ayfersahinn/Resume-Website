using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminAwardUpdate : System.Web.UI.Page
    {
        DataSet1TableAdapters.AWARDSTableAdapter dt = new DataSet1TableAdapters.AWARDSTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                txtID.Text = id.ToString();
                txtID.Enabled = false;

                txtAward.Text = dt.getAward(Convert.ToInt16(id))[0].AWARD;
            }
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dt.awardUpdate(txtAward.Text,Convert.ToInt16( txtID.Text));
            Response.Redirect("adminAward.aspx");
        }
    }
}