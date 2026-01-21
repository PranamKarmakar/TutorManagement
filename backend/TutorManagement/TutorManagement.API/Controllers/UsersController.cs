using Microsoft.AspNetCore.Mvc;
using TutorManagement.Application.Dtos.Users;
using TutorManagement.Application.Interfaces;

namespace TutorManagement.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    // POST: api/users
    [HttpPost]
    public async Task<IActionResult> CreateUser(CreateUserRequest request)
    {
        var result = await _userService.CreateUserAsync(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<IActionResult> GetUserById(int Id)
    {
        var result = await _userService.GetUserByIdAsync(Id);
        return Ok(result);
    }
}
