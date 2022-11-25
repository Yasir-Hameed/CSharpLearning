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
        List<Student> Display()
        {
            foreach (var item in StudentsListDb)
            {

            }
        }


    }
