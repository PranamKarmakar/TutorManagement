using Microsoft.EntityFrameworkCore;
using TutorManagement.Domain.Entities;

namespace TutorManagement.Infrastructure.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(TutorDbContext context)
        {
            if (!await context.Roles.AnyAsync(r => r.Name == "Admin"))
            {
                var roles = new List<Role>
                {
                    new Role { Name = "Admin", Description = "System Administrator" },
                    new Role { Name = "Tutor", Description = "Teacher" },
                    new Role { Name = "Student", Description = "Student" }
                };

                context.Roles.AddRange(roles);
                await context.SaveChangesAsync();
            }
        }

    }
}
