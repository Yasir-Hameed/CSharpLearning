﻿using System;
namespace OOP.Abstraction
{
    public class NewStu : IStudent, IStaff 
    {
        public void StudentPass()
        {
         Console.WriteLine("All Student are Pass");
        }
        
        public void StudentFail()
        {
         Console.WriteLine("All Student are Fail");
        }
        public void StaffAttendance()
        {
            Console.WriteLine("Present");
        }
    }
}