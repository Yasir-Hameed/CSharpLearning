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
        public void DisplayStudent (StudentCap studentobj1)
        {
            foreach (var item in StudentDb)
            {
                Console.WriteLine($"First Name:{item.FirstName}");
                Console.WriteLine($"Last Name:{item.LastName}");
                Console.WriteLine($"Rol No: {item.RollNo}");
            }
        }

    }
}
