using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBHProject
{
    public partial class LogoutControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.IsAuthenticated)
            {
                linkLogout.NavigateUrl = "~/Login.aspx?ReturnUrl=/LogoutComplete.aspx&logout=true";
                linkLogout.Visible = true;
            }
            else
            {
                linkLogout.Visible = false;
            }
        }
    }
}