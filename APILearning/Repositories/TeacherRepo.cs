using APILearning.Models;
using APILearning.StudentService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APILearning.StudentRepos
{
    public class TeacherRepo : ITeacherRepo
    {
        public static List<Teacher> TeachersList = new List<Teacher>();


        private IStudentRepo _studentRepo;
        public TeacherRepo(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public void AddTeacher(Teacher teacher)
        {
            if (teacher != null)
            {
                TeachersList.Add(teacher);
            }

        }

        public List<Teacher> GetTeacher()
        {
            var getStudents = _studentRepo.GetStudents();

            foreach (var teacher in TeachersList)
            {
                teacher.students = getStudents.Where(x => x.teacherId == teacher.Id).ToList();
            }

            return TeachersList;
        }

        public void UpdateTeacher(Teacher teacher1)
        {
            Teacher NewTeacher = TeachersList.Find(x => x.Salary == teacher1.Salary);

            NewTeacher.Name = teacher1.Name;
            NewTeacher.Age = teacher1.Age;
            NewTeacher.Salary = teacher1.Salary;

        }
        public void DelTeacher(int salary)
        {
            Teacher del = TeachersList.Find(x => x.Salary == salary);

            TeachersList.Remove(del);
        }


    }
}

