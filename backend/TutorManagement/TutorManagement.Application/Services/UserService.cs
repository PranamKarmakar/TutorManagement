using TutorManagement.Application.Dtos.Users;
using TutorManagement.Application.Interfaces;
using TutorManagement.Domain.Entities;

namespace TutorManagement.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IRoleRepository _roleRepository;

    public UserService(IUserRepository userRepository, IRoleRepository roleRepository)
    {
        _userRepository = userRepository;
        _roleRepository = roleRepository;
    }

    public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
    {
        bool roleExists = await _roleRepository.ExistsAsync(request.RoleId);

        if (!roleExists)
            throw new ApplicationException("Role not exist! Try a valid Role.");

        User user = new User{FullName = request.FullName,Email = request.Email,RoleId = request.RoleId};

        user = await _userRepository.AddUserAsync(user);
        var RoleName = await _roleRepository.GetRoleNameAsync(request.RoleId);

        return new UserResponse{Id = user.Id,FullName = user.FullName,Email = user.Email,RoleName = RoleName};
    }

    public async Task<UserResponse?> GetUserByIdAsync(int Id)
    {
        var user = await _userRepository.GetUserByIdAsync(Id);
        if (user == null)
        {
            return null;
        }

        var roleName = await _roleRepository.GetRoleNameAsync(user.RoleId);
        return new UserResponse
        {
            Id = user.Id,
            FullName = user.FullName,
            Email = user.Email,
            RoleName = roleName
        };
    }
}
