using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Caching_Prj
{
    public partial class RedirectVsTransfer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGetData_Click(object sender, EventArgs e)
        {
            Context.Items.Add("Name", txtname.Text);
            Context.Items.Add("Email", txtemail.Text);

            // Response.Write(Context.Items["Name"].ToString() + " " + Context.Items["Email"].ToString());

            //1. Redirect
            // Response.Redirect("Page2.aspx"); //this resource is in the same web server

            // Response.Redirect("https://www.amazon.com"); // resource in some other server

            //2. Transfer
             Server.Transfer("Page1.aspx");

            Server.Transfer("https://www.amazon.com"); //cannot move to the webservers
        }
    }
}