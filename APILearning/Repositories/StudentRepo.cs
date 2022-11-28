using APILearning.Models.StudentModels;
using System.Collections.Generic;

namespace APILearning.StudentService
{
    public class StudentRepo : IStudentRepo
    {
        List<Student> StudentsListDb = new List<Student>();

        public void AddStudent(Student student)
        {
            try
            {
                if (student != null)
                    StudentsListDb.Add(student);
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        public List<Student> GetStudents()
        {
            return StudentsListDb;
        }

        public void UpdateStudent(Student updatedStudent)
        {
            Student prvStudent = StudentsListDb.Find(x => x.Id == updatedStudent.Id);

            prvStudent.Id = updatedStudent.Id;
            prvStudent.FName = updatedStudent.FName;
            prvStudent.LName = updatedStudent.LName;
            prvStudent.Mail = updatedStudent.Mail;
            prvStudent.Marks = updatedStudent.Marks;

        }
        
        
        
    }
}
