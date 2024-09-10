using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminExperienceUpdate : System.Web.UI.Page
    {
        DataSet1TableAdapters.EXPERIENCETableAdapter dt = new DataSet1TableAdapters.EXPERIENCETableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);

                txtId.Enabled = false;
                txtId.Text = id.ToString();

                txtTopic.Text = dt.getExperience(Convert.ToInt16(id))[0].TOPIC;
                txtSubtitle.Text = dt.getExperience(Convert.ToInt16(id))[0].SUBTITLE;
                txtDesc.Text = dt.getExperience(Convert.ToInt16(id))[0].DESCRIPTION;
                txtDate.Text = dt.getExperience(Convert.ToInt16(id))[0].DATE;

            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dt.experienceUpdate(txtTopic.Text,txtSubtitle.Text, txtDesc.Text,txtDate.Text,Convert.ToInt16(txtId.Text));
            Response.Redirect("adminExperience.aspx");
        }
    }
}