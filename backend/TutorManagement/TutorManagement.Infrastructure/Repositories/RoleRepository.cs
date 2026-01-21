using Azure.Core;
using Microsoft.EntityFrameworkCore;
using TutorManagement.Application.Interfaces;
using TutorManagement.Infrastructure.Data;

public class RoleRepository : IRoleRepository
{
    private readonly TutorDbContext _context;

    public RoleRepository(TutorDbContext context)
    {
        _context = context;
    }

    public async Task<bool> ExistsAsync(int roleId)
    {
        return await _context.Roles.AnyAsync(r => r.Id == roleId);
    }

    public async Task<string> GetRoleNameAsync(int roleId)
    {
        return await _context.Roles.Where(r => r.Id == roleId).Select(r => r.Name).FirstAsync();
    }
}
