using APILearning.Models.StudentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILearning.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int CrHours { get; set; }
        public int studentId { get; set; }
        public Student student { get; set; }
    }
}
