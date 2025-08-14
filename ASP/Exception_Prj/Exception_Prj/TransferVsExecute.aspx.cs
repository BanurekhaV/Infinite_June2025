using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exception_Prj
{
    public partial class TransferVsExecute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecute_Click(object sender, EventArgs e)
        {
            Server.Execute("~/WebForm2.aspx", true);
            lblstatus.Text = "The call returned after processing the webform2";
        }

        protected void btnExecuteExternal_Click(object sender, EventArgs e)
        {
            Server.Execute("https://www.amazon.in");
        }
    }
}