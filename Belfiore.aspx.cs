using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CBHProject
{
    public partial class Belfiore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strFileName = FileUpload1.FileName;
            if (strFileName == "")
            {
                BelTextBox.Text = "Please select CSV file to upload!";
            }
            else
            {
                projmanconnect p = new projmanconnect();
                p.belfioreFill(strFileName);
                BelTextBox.Text += String.Format("Updated bel_phx with {0}. \n", strFileName);
            }
        }
    }
}