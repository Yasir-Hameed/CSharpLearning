using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    interface IStudentService
    {
        public Student ObjectStudent();
        public void AddNewStudent(Student NewStudent);
        public Address AddressObject();
    }
}
