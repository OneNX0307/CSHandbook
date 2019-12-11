using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public class MembershipElement : ConfigurationElement
    {
        [ConfigurationProperty("username", IsRequired = true, IsKey = true)]
        public string Username
        {
            get { return base["username"] as string; }
            set { base["username"] = value; }
        }

        [ConfigurationProperty("password", IsRequired = true, IsKey = false)]
        public string Password
        {
            get { return base["password"] as string; }
            set { base["password"] = value; }
        }

        [ConfigurationProperty("role")]
        public string Role
        {
            get { return base["role"] as string; }
            set { base["role"] = value; }
        }
    }
}
