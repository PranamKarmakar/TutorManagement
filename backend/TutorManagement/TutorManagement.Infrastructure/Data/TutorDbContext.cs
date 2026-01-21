using Microsoft.EntityFrameworkCore;
using System.Data;
using TutorManagement.Domain.Entities;

namespace TutorManagement.Infrastructure.Data
{
    public class TutorDbContext : DbContext
    {
        public TutorDbContext(DbContextOptions<TutorDbContext> options) : base(options){}

        // ===== DbSets =====
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        //public DbSet<Batch> Batches { get; set; }
        //public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ===== User → Role (Many-to-One) =====
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("MstUsers");

                entity.HasOne(u => u.Role)
                      .WithMany(r => r.Users)
                      .HasForeignKey(u => u.RoleId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("MstRoles");
            });

        }
    }
}
