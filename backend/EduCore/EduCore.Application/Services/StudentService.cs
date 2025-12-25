using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.Domain.Entities;
using EduCore.Application.Interfaces;

namespace EduCore.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _repo.GetAll();
        }
    }
}

