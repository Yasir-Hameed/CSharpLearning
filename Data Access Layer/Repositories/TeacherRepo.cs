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

        public void UpdateTeacher(Teacher newTeacher1)
        {
            Teacher oldTeacher = TeachersListDB.Find(x => x.Salary == newTeacher1.Salary);

            if (newTeacher1 != null)
            {
                oldTeacher.Name = newTeacher1.Name;
                oldTeacher.Age = newTeacher1.Age;
                oldTeacher.Salary = newTeacher1.Salary;
            }

        }
        public void DelTeacher(int salary)
        {
            Teacher del = TeachersListDB.Find(x => x.Salary == salary);

            TeachersListDB.Remove(del);
        }


    }
}

