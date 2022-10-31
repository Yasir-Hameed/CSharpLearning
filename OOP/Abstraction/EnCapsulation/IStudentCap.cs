using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InCapsulation
{
    interface IStudentCap
    {
        List<StudentCap> TakingUserInputs();
        void DisplayStudent();
        void AddStudent(List<StudentCap> studentList);
        void DeleteStudent(int id);
    }
}
