using Microsoft.EntityFrameworkCore;
using TutorManagement.Application.Interfaces;
using TutorManagement.Domain.Entities;
using TutorManagement.Infrastructure.Data;

namespace TutorManagement.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly TutorDbContext _context;

    public UserRepository(TutorDbContext context)
    {
        _context = context;
    }

    public async Task<User> AddUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserByIdAsync(int Id)
    {
       return await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
    }
}
