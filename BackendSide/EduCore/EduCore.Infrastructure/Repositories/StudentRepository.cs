using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EduCore.Application.Interfaces;
using EduCore.Domain.Entities;


namespace EduCore.Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { Id = 1, FullName = "Rahul Das", Class = "10" , IsActive = true }
            };
        }
    }
}
