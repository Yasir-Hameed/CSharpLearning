using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InCapsulation
{
    class StudentCapRepo : IStudentCap
    {
        List<StudentCap> StudentDb = new List<StudentCap>();
        public void  AddStudent(StudentCap studentobj1)
        {
            StudentDb.Add(studentobj1);
        }

        public void DisplayStudent()
        {
            foreach (var item in StudentDb)
            {
                Console.WriteLine($"My First Name:{item.FirstName}");
                Console.WriteLine($"My Last Name:{item.LastName}");
                Console.WriteLine($"My Roll No: {item.RollNo}");
            }
        }

    }
}
