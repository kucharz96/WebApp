using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebProject.Models;

namespace WebProject.Code.Authorization
{
    public class CustomMembershipUser : MembershipUser
    {
        #region User Properties  

        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Role> Roles { get; set; }

        #endregion

        public CustomMembershipUser(User user) : base("CustomMembership", user.Username, user.UserId, user.Email, string.Empty, string.Empty, true, false, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now)
        {
            UserId = user.UserId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Roles = user.Roles;
        }
    }
}