namespace TutorManagement.Application.Dtos.Users
{
    public class CreateUserRequest
    { 
        public string  FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int RoleId { get; set; }
    }
} 
