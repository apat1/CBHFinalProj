using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBHProject
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            projmanconnect p = new projmanconnect();
            p.builderFill(TextBox28, TextBox1, TextBox2, TextBox3,TextBox4,TextBox5,TextBox6,TextBox7,TextBox8,TextBox9,TextBox10,TextBox11,TextBox12,TextBox13,TextBox14,TextBox15,TextBox16,TextBox17,TextBox18,TextBox19,TextBox20,TextBox21,TextBox22,TextBox23,TextBox24,TextBox25,TextBox26,TextBox27);
        }
    }
}