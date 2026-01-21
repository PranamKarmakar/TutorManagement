using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TutorManagement.Domain.Common;

namespace TutorManagement.Domain.Entities
{
    public class User : AuditableEntity
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public int RoleId {  get; set; }
        public Role? Role { get; set; }
    }
}
