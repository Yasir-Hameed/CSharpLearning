using APILearning.Repositories;
using APILearning.StudentRepos;
using Domain_Entity;
using System.Collections.Generic;
using System.Linq;

namespace Data_Access_Layer
{
    public class StudentRepo : IStudentRepo
    {
        public static List<Student> StudentsListDb = new List<Student>();

        public Student AddStudent(Student student)
        {
            try
            {
                if (student != null)
                  StudentsListDb.Add(student);
                return student;
                
            }
            catch (System.Exception)
            {
                throw;
            }

        }

        public List<Student> GetStudents()
        {

            var teacherList = TeacherRepo.TeachersListDB;
            foreach (var student in StudentsListDb)
            {

                student.teacher = teacherList.FirstOrDefault(x => x.Id == student.teacherId);
            }
            return StudentsListDb;
//return StudentsListDb.ToList();
        }
        
        public Student UpdateStudent(Student updatedStudent)
        {
            Student prvStudent = StudentsListDb.Find(x => x.Id == updatedStudent.Id);

            prvStudent.Id = updatedStudent.Id;
            prvStudent.FName = updatedStudent.FName;
            prvStudent.LName = updatedStudent.LName;
            prvStudent.Mail = updatedStudent.Mail;
            prvStudent.Marks = updatedStudent.Marks;
            return prvStudent;
        }
        public List<Student> StudentCourse()
        {
            var listofcourse = CourseRepo.CourseDB;

            foreach (var item in StudentsListDb)
            {
                item.course = listofcourse.Where(x => x.studentId == item.Id).ToList();
            }
            return StudentsListDb;
        }
        
        
        
    }
}
