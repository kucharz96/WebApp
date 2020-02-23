using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Code.Authorization
{
    public class CustomSerializeModel
    { 
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<string> RoleName { get; set; }
    }
}
