using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Abstraction.EnCapsulation
{
    class ChefRepo : IChefService
    {
        List<Chef> MasterList = new List<Chef>();

        public List<Chef> UserInput()
        {
            int abc = 0;
            Console.WriteLine("Enter Number of Chefs");
            abc = int.Parse(Console.ReadLine());

            List<Chef> ChildList = new List<Chef>();
            //Chef Objchef = new Chef();
            for (int i = 0; i <= abc; i+=2)
            {
                Chef Objchef = new Chef();

                Console.WriteLine("Enter First Name");
                Objchef.Name = (Console.ReadLine());

                Console.WriteLine("Enter Age");
                Objchef.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Code");
                Objchef.code = int.Parse(Console.ReadLine());

                ChildList.Add(Objchef);

            }
            return ChildList;



        }

        public List<Chef> AddNewChef(List<Chef> abc)
        {
            MasterList.AddRange(abc);
            return MasterList;
        }

        


        public void Deletechef(int Id)
        {
            Chef delchef = MasterList.FirstOrDefault(x => x.code == Id);
            MasterList.Remove(delchef);
        }

        public void Display()

	{
            foreach (var item in MasterList)
            {
                Console.WriteLine($"Chef Name:{item.Name}");
                Console.WriteLine($"Chef Age:{item.Age}");
                Console.WriteLine($"Chef Code:{item.code}");

            }
	}
    }
}
