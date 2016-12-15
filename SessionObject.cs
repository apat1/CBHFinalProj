using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CBHProject
{
    public class SessionObject
    {
        private string username = "";
        private HashSet<String> roles = new HashSet<String>();

        public string getUserName()
        {
            return username;
        }
        public void setUserName(String username)
        {
            this.username = username;
        }

        public void addRole(String roleName)
        {
            roles.Add(roleName);
        }
    }
}