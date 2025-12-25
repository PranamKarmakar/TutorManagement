using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EduCore.Domain.Entities;

namespace EduCore.Application.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
    }
}
