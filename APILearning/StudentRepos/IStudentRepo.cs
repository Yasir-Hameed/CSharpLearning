using APILearning.Models.StudentModels;
using System.Collections.Generic;

namespace APILearning.StudentService
{
    public interface IStudentRepo
    {
        void AddStudent(Student student);
        List<Student> Display();
    }
}
