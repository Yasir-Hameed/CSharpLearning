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
        public void DelStudent(int Id);
        public List<Student> AddNewList();
        public void AddStudentList(List<Student> students);
        public void Display();
    }
}
