using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVBlog
{
    public partial class adminAbout : System.Web.UI.Page
    {
        DataSet1TableAdapters.ABOUTTableAdapter dt = new DataSet1TableAdapters.ABOUTTableAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                txtName.Text = dt.aboutList()[0].NAME;
                txtSurname.Text = dt.aboutList()[0].SURNAME;
                txtAdress.Text = dt.aboutList()[0].ADDRESS;
                txtEmail.Text = dt.aboutList()[0].MAIL;
                txtPhone.Text = dt.aboutList()[0].PHONE;
                txtNotes.Text = dt.aboutList()[0].NOTES;
                txtImg.Text = dt.aboutList()[0].IMAGE;
            }
            


        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.aboutUpdate(txtName.Text, txtSurname.Text, txtAdress.Text, txtEmail.Text, txtPhone.Text, txtNotes.Text, txtImg.Text);
            Response.Redirect("default.aspx");
        }
    }
}