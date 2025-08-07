using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ViewStateForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = txtusername.Text;
            ViewState["pass"] = txtpassword.Text;
            txtusername.Text = "";
            txtpassword.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            //lblmessage.Text = "Your Name is : " + ViewState["uname"].ToString() + 
            //    " and your Password is : "+ ViewState["pass"].ToString();

            //or

            //string u = ViewState["uname"].ToString();
            //string p = ViewState["pass"].ToString();

            //lblmessage.Text = "Your Login is : " + u + " and password is :" + p;

            //let us check if data reatined by viewstate can travel to other page
            Response.Redirect("TestForm.aspx");
        }
    }
}