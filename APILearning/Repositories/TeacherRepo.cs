using APILearning.Models;
using APILearning.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APILearning.StudentRepos
{
    public class TeacherRepo : ITeacherRepo
    {
        public static List<Teacher> TeachersListDB = new List<Teacher>();


        private IStudentRepo _studentRepo;
        public TeacherRepo(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                TeachersListDB.Add(teacher);
            }

        }

        public List<Teacher> GetTeacher()
        {
            var getStudents = _studentRepo.GetStudents();

            foreach (var teacher in TeachersListDB)
            {
                teacher.students = getStudents.Where(x => x.teacherId == teacher.Id).ToList();
            }

            return TeachersListDB;
        }

        public void UpdateTeacher(Teacher teacher1)
        {
            Teacher NewTeacher = TeachersListDB.Find(x => x.Salary == teacher1.Salary);

            NewTeacher.Name = teacher1.Name;
            NewTeacher.Age = teacher1.Age;
            NewTeacher.Salary = teacher1.Salary;

        }
        public void DelTeacher(int salary)
        {
            Teacher del = TeachersListDB.Find(x => x.Salary == salary);

            TeachersListDB.Remove(del);
        }


    }
}

