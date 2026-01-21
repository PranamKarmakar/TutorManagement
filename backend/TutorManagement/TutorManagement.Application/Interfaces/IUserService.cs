using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorManagement.Application.Dtos.Users;

namespace TutorManagement.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> CreateUserAsync(CreateUserRequest request);
        Task<UserResponse?> GetUserByIdAsync(int Id);
    }
}
