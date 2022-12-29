using Domain_Entity;
using System.Collections.Generic;

namespace Data_Access_Layer
{
    public interface IStudentRepo
    {
        Student AddStudent(Student student);

         List<Student> GetStudents();
         Student UpdateStudent(Student student);
        List<Student> StudentCourse();


    }
}
