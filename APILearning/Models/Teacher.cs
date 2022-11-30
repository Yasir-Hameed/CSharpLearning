using APILearning.Models.StudentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILearning.Models
{
    public class Teacher
    {

        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public int Salary { get; set; }

       public  List<Student> students { get; set; } 
            
    }
}
