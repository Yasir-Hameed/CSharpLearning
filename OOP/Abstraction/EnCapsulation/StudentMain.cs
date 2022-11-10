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

            Student Stud = StudentObj1.ObjectStudent();

            StudentObj1.AddNewStudent(Stud);

            StudentObj1.Display();
        }        
    }
}
