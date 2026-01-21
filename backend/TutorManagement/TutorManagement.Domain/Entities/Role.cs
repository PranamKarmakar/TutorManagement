using System.Collections.Generic;
using TutorManagement.Domain.Common;

namespace TutorManagement.Domain.Entities
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; } = null!;   // Admin, Tutor, Student
        public string? Description { get; set; }

        // Navigation
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
