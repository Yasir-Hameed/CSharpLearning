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

        [HttpPost("AddStudents")]
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
        
        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {  
                return Ok(_studentRepo.GetStudents());
            }
            catch
            {
               return BadRequest("Not Added!");
            }
            
        }  

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                _studentRepo.UpdateStudent(student);
                return Ok();
            }
            catch
            {
               return BadRequest("Not Added!");
            }
            
        }
        [HttpGet("Getcourse")]
        public IActionResult GetStudentCourse()
        {
            try
            {
                return Ok(_studentRepo.StudentCourse());
            }
            catch
            {
                return BadRequest("Not Added!");
            }

        }

    }
}
