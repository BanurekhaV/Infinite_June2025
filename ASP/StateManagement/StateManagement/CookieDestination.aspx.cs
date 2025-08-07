using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            //1. using persistent cookie
            //HttpCookie rc = Request.Cookies["OurCookie"]; //accessing the named cookie
            //lblname.Text = rc["d1"];
            //lblpassword.Text = rc["d2"];

            //2. non-persistent cookie
            lblname.Text = Request.Cookies["un"].Value.ToString();
            lblpassword.Text = Request.Cookies["pwd"].Value.ToString();
        }
    }
}