using APILearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILearning.Repositories
{
  public  interface ICourse
    {
        public void AddCourse(Course course);
        public void UpdateCourse();
        public void DelCourse();
        public List<Course> AllCourse();




    }
}
