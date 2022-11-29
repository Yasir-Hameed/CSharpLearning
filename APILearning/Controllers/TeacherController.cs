using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILearning.Models;
using APILearning.StudentRepos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private ITeacherRepo teacherRepo;
        public TeacherController(ITeacherRepo _teacherRepo)
        {
            teacherRepo = _teacherRepo;
        }

       [HttpPost("InsertTeacher")] 
       public IActionResult AddTeacher(Teacher teacher)
        {
            teacherRepo.AddTeacher(teacher);
            return Ok();
        }

        [HttpPut("UpdateTeacher")]
        public IActionResult UpdateTeacher(Teacher teacher2)
        {
            teacherRepo.UpdateTeacher(teacher2);
            return Ok();
        }

        [HttpGet("GetTeacher")]

        public IActionResult GetTeacher()
        {
            return Ok(teacherRepo.GetTeacher());

        }

        [HttpDelete("Delete")]
        public IActionResult DeleteTeacher(int Salary)
        {
            teacherRepo.DelTeacher(Salary);
            return Ok(teacherRepo.GetTeacher());
        }
        [HttpGet("Id")]

        public string GetEmployeebyId(int id)
        {
            return $"EmployeeDetails{id}";
        }
    }
}
