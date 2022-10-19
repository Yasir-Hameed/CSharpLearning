using System;

namespace OOP.ObjInitialize
{
    class Animal
    {
        public string E, R, L;
        

        // By Default Constructor
        public Animal()
        {

        }

        public Animal (string Eating, string Run, string Looking)
        {
            E = Eating; R = Run; L = Looking;
        }
        public void AnimalEat()
        {
            Console.WriteLine("animal eating");
        }
        public void AnimalRun()
        {
            Console.WriteLine("animal Run");
        }
        public void AnimalLooking()
        {
            Console.WriteLine("animal Looking");
        }
    }
} 