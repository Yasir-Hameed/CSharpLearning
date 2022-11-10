using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    public class Student
    {
        public Student()
        {

        }
        public Student(Student student, Address address)
        {
            student.Address = address;
        }


        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mail { get; set; }
        public int Marks { get; set; }
       public Address Address { get; set; }
       
    }
}
