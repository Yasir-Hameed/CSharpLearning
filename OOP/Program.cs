using OOP.Abstraction;
using OOP.Inheritance;
using OOP.ObjInitialize;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            // By Using Method

            //Teachers teacherObj = new Teachers();
            //teacherObj.GetStudentInfo();   



            //Animal animal = new Animal();
            //animal.AnimalEat();

            // By using Referece Variables
            //Dump dump = new Dump();
            //dump.eats = "Animal Eating";
            //dump.Date = DateTime.Now;

            //By using Constructors
            //Dump dump1 = new Dump("Animal Eating", "Animal Eating", "Animal Eating");

            //Console.WriteLine(dump1.eats);

            //IStudent student = new NewStu();
            // student.StudentPass();

            //IStudent Obj = new NewStu1();
            // Obj.StudentFail();

            //IStaff StaffObj = new NewStu1();
            //StaffObj.StaffAttendance(); 

            //IStaff StaffObJNew = new NewStu();
            //StaffObj.StaffAttendance();

            Cuboid objCub  = new Cuboid();

            (int Length, int Width) = objCub.TakingInputsFromTheUser();

            Cuboid objcub = new Cuboid(Length, Width);

            Console.WriteLine(objcub.Area());

            Console.WriteLine(objcub.parameter());

            OverrideingP ObjOver = new OverrideingP();

            OverLoading ObjLoad = new OverLoading(1,2);
            OverLoading ObjLoadOther = new OverLoading();
            ObjLoad.Add();
            ObjLoadOther.Add(1, 1.0f, 2.0f);
            ObjLoadOther.Add(1,2f,2.4f);
            ObjLoadOther.Add(1.0,2.0,2.4f);
        }
    }
}