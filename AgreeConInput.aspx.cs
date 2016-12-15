using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBHProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            projmanconnect p = new projmanconnect();
            p.aggreementConstructionFill(TextBox7, TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12);
            
        }

    }
}