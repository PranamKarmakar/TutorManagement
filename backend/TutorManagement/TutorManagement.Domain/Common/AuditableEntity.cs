using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorManagement.Domain.Common
{
    public class AuditableEntity : BaseEntity
    {
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public int? CreatedByUserId { get; set; }
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        public int? UpdatedByUserId { get;set; }
        public bool IsActive { get; set; } = true;
    }
}
