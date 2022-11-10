using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    class RepStudentService : IStudentService
    {
        List<Student> StudentDB = new List<Student>();
        public Student ObjectStudent()
        {
            Student Stud = new Student();

            Console.WriteLine("Enter Student Id");
            Stud.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter First Name");
            Stud.FName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            Stud.LName = Console.ReadLine();

            Address address = AddressObject();

            new Student(Stud, address);

            return Stud;

        }

        public void AddNewStudent(Student NewStudent)
        
       {
            StudentDB.Add(NewStudent);
        }


        public Address AddressObject()
        {
            Address AddressObj = new Address();

            Console.WriteLine("Please Enter address Id");
            AddressObj.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Street No:");
            AddressObj.StreetNO = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter House No.");
            AddressObj.HouseNO = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter City Name:");
            AddressObj.City = Console.ReadLine();

            return AddressObj;
        }
    }
}
