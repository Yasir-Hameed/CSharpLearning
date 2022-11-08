using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mail { get; set; }
        public int Marks { get; set; }

        public Address Address { get; set; }
       
    }
}
