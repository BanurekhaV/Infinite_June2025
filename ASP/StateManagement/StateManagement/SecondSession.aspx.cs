using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SecondSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetSession_Click(object sender, EventArgs e)
        {
            lblname.Text = Session["name"].ToString();
            lblcity.Text = Session["city"].ToString();
        }

        protected void btnthird_Click(object sender, EventArgs e)
        {
            Response.Redirect("ThirdSession.aspx");
        }
    }
}