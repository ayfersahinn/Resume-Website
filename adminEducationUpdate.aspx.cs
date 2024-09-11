using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminEducationUpdate : System.Web.UI.Page
    {
        DataSet1TableAdapters.EDUCATIONTableAdapter dt = new DataSet1TableAdapters.EDUCATIONTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                txtID.Enabled = false;
                txtID.Text = id.ToString();
                txtTopic.Text = dt.getEducation(Convert.ToInt16(id))[0].TOPIC;
                txtSubtitle.Text = dt.getEducation(Convert.ToInt16(id))[0].SUBTITLE;
                txtDesc.Text = dt.getEducation(Convert.ToInt16(id))[0].DESCRIPTION;
                txtGpa.Text = dt.getEducation(Convert.ToInt16(id))[0].GPA;
                txtDate.Text = dt.getEducation(Convert.ToInt16(id))[0].DATE;
            }
            
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            dt.educationUpdate(txtTopic.Text,txtSubtitle.Text,txtDesc.Text,txtGpa.Text,txtDate.Text,Convert.ToInt16(txtID.Text));
            Response.Redirect("adminEducation.aspx");
        }
    }
}