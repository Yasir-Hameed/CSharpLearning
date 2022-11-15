using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    class StudentMain
    {
        static void Main()
        {
            IStudentService StudentObj1 = new RepStudentService();

            //Student Stud = StudentObj1.ObjectStudent();

            //StudentObj1.AddNewStudent(Stud);

            var NewList = StudentObj1.AddNewList();


            StudentObj1.AddStudentList(NewList);
          
            
            int Id;
            Console.WriteLine("Enter Student Id to Delete");
            Id = int.Parse(Console.ReadLine());
            StudentObj1.DelStudent(Id);

            StudentObj1.Display();
        }        
    }
}
