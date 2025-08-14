using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class CrossPageDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage !=null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox txtName = (TextBox)PreviousPage.FindControl("txtName");
                lblName.Text = "Welcome " + txtName.Text;
            }
            else
            {
                Response.Redirect("CrossPageIndex.aspx");
            }
        }
    }
}