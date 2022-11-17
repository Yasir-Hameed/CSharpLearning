using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    class RepStudentService : IStudentService
    {
       public List<Student> StudentDB = new List<Student>();
        public Student ObjectStudent()
        {
            try
            {
                Student Stud = new Student();
                Student student = new Student();

                Console.WriteLine("Enter Student Id");
                Stud.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter First Name");
                Stud.FName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                Stud.LName = Console.ReadLine();

                Stud.Address = AddressObject();

                return Stud;
            }
            catch (Exception)
            {

                throw ;
            }
           
        }

        public void AddNewStudent(Student NewStudent)

        {
            StudentDB.Add(NewStudent);
        }


        public Address AddressObject()
        {
            try
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
            catch (Exception)
            {
                throw;
            }
           
        }

        public List<Student> AddNewList()
        {
            try
            {
                int NoOfStudent;
                Console.WriteLine("Please Enter Number of Entries");
                NoOfStudent = int.Parse(Console.ReadLine());

                List<Student> ChildList = new List<Student>();

                for (int i = 0; i < NoOfStudent; i++)
                {
                    Student Stud2 = new Student();

                    Console.WriteLine("Enter First Name");
                    Stud2.FName = (Console.ReadLine());
                    Console.WriteLine("Enter Last Name");
                    Stud2.LName = (Console.ReadLine());
                    Console.WriteLine("Enter Address");
                    Stud2.Address = AddressObject();

                    ChildList.Add(Stud2);
                }
                return ChildList;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public void  AddStudentList(List<Student> students)
        {
            StudentDB.AddRange(students);
           
        }



        public void DelStudent(int Id)
        {
            Student DelStud = StudentDB.FirstOrDefault(x => x.Address.Id == Id);
            StudentDB.Remove(DelStud);
        }
        
        
        public void Display()
        {
            foreach (var item in StudentDB)
            {
                Console.WriteLine($"{item.FName} , {item.LName},{item.Address.City};{item.Address.HouseNO};{item.Address.StreetNO}");
                
            }
        }
    }
}
