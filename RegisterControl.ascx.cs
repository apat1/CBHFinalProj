using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Text;
using System.Xml;

namespace CBHProject
{
    public partial class RegisterControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            startCaptcha();
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            bool valid = validateCaptcha();                                                                    /*CAPTCHA ITEGRATION*/

            string password1 = textPassword.Text;
            string password2 = textConfirm.Text;

            // Check if username is empty
            if (IsStringEmpty(textUsername.Text))
            {
                // Check if the passwords match
                if (IsMatch(password1, password2))
                {
                    string user = textUsername.Text;

                    XmlDocument configDoc = new XmlDocument();
                    XmlElement myRoot = null;
                    try
                    {
                        configDoc.Load(Server.MapPath("Web.config"));
                        myRoot = configDoc.DocumentElement;
                        XmlNodeList myNodes = myRoot.GetElementsByTagName("user");

                        bool uniqueName = true;
                        foreach (XmlNode userNode in myNodes)
                        {
                            string currentName = userNode.Attributes[0].Value;
                            if (currentName != null && currentName == user)
                            {
                                uniqueName = false;
                                break;
                            }
                        }

                        if (!uniqueName)
                        {
                            lblError.Text = "Username already taken.";
                            startCaptcha();                                                                     /*CAPTCHA ITEGRATION*/
                        }
                        else
                        {
                            XmlNodeList cNodes = myRoot.GetElementsByTagName("credentials");
                            foreach (XmlNode currentNode in cNodes)
                            {
                                XmlElement newUser = addXmlElement(configDoc, user, password1);
                                currentNode.AppendChild(newUser);
                                // Save changes to Web.config file
                                configDoc.Save(Server.MapPath("Web.config"));
                                // Registration Complete
                                Response.Redirect("RegisterComplete.aspx");
                            }
                        }
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        lblError.Text = "ERROR! Web.config file not found!";
                    }
                }
                else
                {
                    lblError.Text = "Password and confirmation password must match or not be blank.";
                    startCaptcha();                                                                             /*CAPTCHA ITEGRATION*/
                }
            }
        }

        // Helper method to check if username is empty
        private bool IsStringEmpty(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                lblError.Text = "Please enter a username.";
                startCaptcha();                                                                                 /*CAPTCHA ITEGRATION*/
                return false;
            }
            else
            {
                return true;
            }
        }

        // Helper method to check if the password and confirmation password matches
        private bool IsMatch(string password1, string password2)
        {
            /*FIXING BUG-ABLE TO REGISTER WITH BOTH FIELDS BLANK*/
            if (password1 != "" && password2 != "")
            {
                return (password1 == password2);
            }
            else
            {
                return false;
            }
        }

        // Method to add username and password as XmlElement in web.config file
        public static XmlElement addXmlElement(XmlDocument configDoc, string user, string pw)
        {
            XmlElement newUser = configDoc.CreateElement("user");
            newUser.SetAttribute("name", user);
            newUser.SetAttribute("password", pw);

            return newUser;
        }

        protected void startCaptcha()
        {
            com.textdisguise.www.CaptchaService cp = new com.textdisguise.www.CaptchaService();
            com.textdisguise.www.ClientAuthModel cm = new com.textdisguise.www.ClientAuthModel();
            com.textdisguise.www.CaptchaImageWordModel wd;
            cm.Guid = "c402e7b7-ce34-48b4-ad80-c9bb4b9dee9e";
            cm.Password = "L0Mi[bh9dBE&(TG.|vO5Xo:*wE";
            wd = cp.GetNewWord(cm);
            Session["wd"] = wd.CaptchaImageGuid;
            Image1.ImageUrl = wd.Url;
        }

        protected bool validateCaptcha()
        {
            com.textdisguise.www.CaptchaService cp = new com.textdisguise.www.CaptchaService();
            com.textdisguise.www.ClientAuthModel cm = new com.textdisguise.www.ClientAuthModel();
            cm.Guid = "c402e7b7-ce34-48b4-ad80-c9bb4b9dee9e";
            cm.Password = "L0Mi[bh9dBE&(TG.|vO5Xo:*wE";
            return cp.ValidateImageWord(cm, Session["wd"].ToString(), textCaptcha.Text.Trim());
        }
    }
}