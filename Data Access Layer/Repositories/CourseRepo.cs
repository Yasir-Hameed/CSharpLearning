using APILearning.Models;
using APILearning.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILearning.Repositories
{
    public class CourseRepo : ICourse
    {
        public static List<Course> CourseDB = new List<Course>();

        private IStudentRepo studentRepo;

        public CourseRepo(IStudentRepo _studentRepo)
        {
            studentRepo = _studentRepo;
        }

        public void AddCourse(Course course)
        {
            if (course != null)
                CourseDB.Add(course);

        }

        public void DelCourse()
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course course)
        {
            var getstudent1 = studentRepo.GetStudents();
            
        }

        public void UpdateCourse()
        {
            throw new NotImplementedException();
        }
        public List<Course> AllCourse()
        {
            return CourseDB.ToList();
        }
    }
}
