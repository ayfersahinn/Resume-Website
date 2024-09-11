using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminSkill : System.Web.UI.Page
    {
        DataSet1TableAdapters.SKILLSTableAdapter dt = new DataSet1TableAdapters.SKILLSTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dt.skillList();
            Repeater1.DataBind();
        }
    }
}