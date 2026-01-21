using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorManagement.Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<bool> ExistsAsync(int roleId);
        Task<string> GetRoleNameAsync(int roleId);
    }

}
