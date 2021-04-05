using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Principal;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConfigurationDemo
{
    public class CustomUsernamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            var member = MembershipProvider.ValidateUser(userName, password);
            if (member == null)
                throw new FaultException<SecurityTokenException>
                (new SecurityTokenException("Authentication failed"), "Unknown Username or Password");
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName),
            member.Role.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}