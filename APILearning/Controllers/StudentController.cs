using APILearning.Models.StudentModels;
using APILearning.StudentService;
using Microsoft.AspNetCore.Mvc;
using System;

namespace APILearning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentRepo _studentRepo;
        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            try
            {
                _studentRepo.AddStudent(student);
                return Ok();
            }
            catch
            {
               return BadRequest("Not Added!");
            }
            
        }

    }
}
