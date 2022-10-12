using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction
{
   public class NewStu1 : IStudent , IStaff
    {
        public void StudentFail()
        {
            Console.WriteLine("These Student are Fail");
        }
        public void StudentPass()
        {
            Console.WriteLine("All Student are Pass");
        }

    public void StaffAttendance()
    {
        Console.WriteLine("Present");
    }

    }


}
