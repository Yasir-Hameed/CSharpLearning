using APILearning.Models;
using APILearning.Models.StudentModels;
using APILearning.StudentRepos;
using System.Collections.Generic;
using System.Linq;

namespace APILearning.StudentService
{
    public class StudentRepo : IStudentRepo
    {
        public static List<Student> StudentsListDb = new List<Student>();

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

            var teacherList = TeacherRepo.TeachersList;
            foreach (var student in StudentsListDb)
            {
                student.teacher = teacherList.FirstOrDefault(x => x.Id == student.teacherId);
            }
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
