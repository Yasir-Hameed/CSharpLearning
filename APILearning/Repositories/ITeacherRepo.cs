using APILearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILearning.StudentRepos
{
    public interface ITeacherRepo
    {
         void AddTeacher(Teacher teacher);
        public List<Teacher> GetTeacher();
        public void UpdateTeacher(Teacher teacher1);
        public void DelTeacher(int salary);



    }
}
