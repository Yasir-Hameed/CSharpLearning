using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InCapsulation
{
    class StudentCapRepo : IStudentCap
    {
        List<StudentCap> StudentDb = new List<StudentCap>();


        public void  AddStudent(List<StudentCap> studentCaps)
        {
            StudentDb.AddRange(studentCaps);
           
        }

        public void AddStudent(StudentCap studentCaps)
        {
            StudentDb.Add(studentCaps);

        }

        public void DisplayStudent()
        {
            foreach (var item in StudentDb)
            {
                Console.WriteLine($"My First Name:{item.FirstName}");
                Console.WriteLine($"My Last Name:{item.LastName}");
                Console.WriteLine($"My Roll No: {item.RollNo}");
                Console.WriteLine($"Total Entries:{item.NumberOfEntries}");
            }
        }

    }
}
