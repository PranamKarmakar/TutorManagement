using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EduCore.Application.Interfaces;

namespace EduCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService _service;
      
        public StudentsController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetStudents());
        }
    }
}
