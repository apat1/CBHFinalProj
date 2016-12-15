using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CBHProject;

namespace CBHProject
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            projmanconnect p = new projmanconnect();
            p.optionCurrentfill(TextBox5, TextBox1,TextBox2,TextBox3,TextBox4);
            
        }
    }
}