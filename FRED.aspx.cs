using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBHProject
{
    public partial class FRED : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBConnect connect = new DBConnect();
            connect.InsertPHXrnsa(TextBox1);
            connect.InsertPhoeURN(TextBox1);
            connect.InsertMariURN(TextBox1);
            connect.InsertMariPOP(TextBox1);
            connect.InsertMariLFN(TextBox1);
            connect.InsertAZSTHPI(TextBox1);
            connect.InsertSPCS20RSA(TextBox1);
            connect.InsertSPCS20RNSA(TextBox1);
            connect.InsertSPCS20RPSNSA(TextBox1);
            connect.InsertSPCS10RSA(TextBox1);
            connect.InsertSPCS10RNSA(TextBox1);
            connect.InsertSPCS10RPSNSA(TextBox1);
        }
    }
}