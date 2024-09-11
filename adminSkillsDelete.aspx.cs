using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminSkillsDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SKILLSTableAdapter dt = new DataSet1TableAdapters.SKILLSTableAdapter();
            int id= Convert.ToInt16(Request.QueryString["ID"]);
            dt.skillDelete(Convert.ToInt16(id));
            Response.Redirect("adminSkill.aspx");
        }
    }
}