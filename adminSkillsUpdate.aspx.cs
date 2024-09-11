using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminSkillsUpdate : System.Web.UI.Page
    {
        DataSet1TableAdapters.SKILLSTableAdapter dt = new DataSet1TableAdapters.SKILLSTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString["ID"]);
                txtID.Enabled = false;
                txtID.Text = id.ToString();

                txtSkill.Text = dt.getSkill(Convert.ToInt16(id))[0].SKILL;
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            dt.skillUpdate(txtSkill.Text, Convert.ToInt16 (txtID.Text));
            Response.Redirect("adminSkill.aspx");
        }
    }
}