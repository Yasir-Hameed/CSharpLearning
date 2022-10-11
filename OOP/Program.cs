using OOP.Inheritance;
using OOP.ObjInitialize;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teachers teacherObj = new Teachers();
            //teacherObj.GetStudentInfo();   

            // By Using Method

            //Animal animal = new Animal();
            //animal.AnimalEat();

            // By using Referece Variables
            //Dump dump = new Dump();
            //dump.eats = "Animal Eating";
            //dump.Date = DateTime.Now;

            // By using Constructors
            Dump dump1 = new Dump("Animal Eating", "Animal Eating", "Animal Eating");
            
            Console.WriteLine(dump1.eats);
        }
    }
}
