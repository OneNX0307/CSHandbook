using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public static class MembershipProvider
    {
        public static MembershipElement GetMember(string userName)
        {
            var memberships = ConfigurationManager.GetSection("memberships") as MembershipConfigurationHandler;
            if (memberships == null || memberships.Members == null || memberships.Members.Count < 1)
                return null;
            return memberships.Members[userName];
        }

        public static MembershipElement ValidateUser(string userName, string password)
        {
            var member = GetMember(userName);
            if (member != null && member.Password.Equals(password))
                return member;
            return null;
        }
    }
}
