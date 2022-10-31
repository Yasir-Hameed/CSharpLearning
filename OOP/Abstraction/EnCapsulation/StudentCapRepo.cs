using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP.InCapsulation
{
    class StudentCapRepo : IStudentCap
    {
        List<StudentCap> StudentDb = new List<StudentCap>();

        public List<StudentCap> TakingUserInputs()
        {
            int NumberOfEntries = 0;
            Console.WriteLine("How many Candidates You want to enter");
            NumberOfEntries = int.Parse(Console.ReadLine());

            List<StudentCap> NewStudentList = new List<StudentCap>();

            for (int i = 0; i < NumberOfEntries; i++)
            {
                StudentCap newStudent = new StudentCap();

                Console.WriteLine("Please Enter First Name");
                newStudent.FirstName = (Console.ReadLine());

                Console.WriteLine("Please Enter Last Name");
                newStudent.LastName = (Console.ReadLine());

                Console.WriteLine("Please Enter Roll No.");
                newStudent.RollNo = int.Parse(Console.ReadLine());

                NewStudentList.Add(newStudent);

                //Console.WriteLine($"Total Entries are:{studentobj1.NumberOfEntries}");

            }
            return NewStudentList;
        }
        public void  AddStudent(List<StudentCap> NewStudentList)
        {
            StudentDb.AddRange(NewStudentList);           
        }

        public void DeleteStudent(int Id)
        {
            StudentCap student = StudentDb.Where(x => x.RollNo == Id).FirstOrDefault();
            StudentDb.Remove(student);
        }

        //public void AddStudent(StudentCap studentCaps)
        //{
        //    StudentDb.Add(studentCaps);

        //}

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
