using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILearning.Models;
using APILearning.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APILearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private ICourse Course;
        public CourseController(ICourse course)
        {
            Course = course; 
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            Course.AddCourse(course);
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAllCourse()
        {
            Course.
           var listcourse= Course.AllCourse();
            return Ok(listcourse);
        }



    }
}
