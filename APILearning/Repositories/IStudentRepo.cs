using APILearning.Models.StudentModels;
using System.Collections.Generic;

namespace APILearning.StudentService
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);

        public List<Student> GetStudents();
        public void UpdateStudent(Student student);
        public List<Student> StudentCourse();


    }
}
