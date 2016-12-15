using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace CBHProject
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String logout = Request.QueryString["logout"];
            if (Request.IsAuthenticated && logout != null && logout == "true")
            {
                doLogout();
            }
            else if (Request.IsAuthenticated && Session["sessObj"] == null)
            {
                doLogout();
            }
            else if (Request.IsAuthenticated)
            {
                Response.Redirect("Deny.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUser.Text;
            if (FormsAuthentication.Authenticate(username, textPass.Text))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                SessionObject sessObj = new SessionObject();
                sessObj.setUserName(username);
                Session["sessObj"] = sessObj;
                redirectToReturnPage();
            }
            else
            {
                lblResult.Text = "Invalid login";
            }
        }

        private void doLogout()
        {
            Session.Clear();
            Session.Abandon();
            HttpContext.Current.User = null;
            FormsAuthentication.SignOut();
            redirectToReturnPage();
        }

        private void redirectToReturnPage()
        {
            string qs = Request.QueryString["ReturnUrl"];
            String uri = "~";
            if (qs != null && qs.Length > 0)
            {
                uri += qs;
            }
            else
            {
                uri += "/Default.aspx";
            }

            Response.Redirect(uri);
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }
    }
}