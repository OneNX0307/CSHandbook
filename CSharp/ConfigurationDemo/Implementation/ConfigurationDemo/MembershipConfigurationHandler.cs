using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public class MembershipConfigurationHandler : ConfigurationSection
    {
        [ConfigurationProperty("", IsDefaultCollection = true, IsKey = false, IsRequired = true)]
        public MembershipCollection Members
        {
            get
            {
                return base[""] as MembershipCollection;
            }
            set
            {
                base[""] = value;
            }
        }
    }
}
