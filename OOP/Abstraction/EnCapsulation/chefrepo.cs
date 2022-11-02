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
            int UserInput = 0;
            Console.WriteLine("Enter Number of Chefs");
            UserInput = int.Parse(Console.ReadLine());

            List<Chef> ChildList = new List<Chef>();
 
            for (int i = 0; i <= UserInput; i+=2)
            {
                Chef Objchef = new Chef();

                Console.WriteLine("Enter First Name");
                Objchef.Name = (Console.ReadLine());
             
                Console.WriteLine("Enter Age");
                int.TryParse(Console.ReadLine(), out int val);
                Objchef.Age = val;

                Console.WriteLine("Enter Code");
                Objchef.code = int.Parse(Console.ReadLine());

                
                ChildList.Add(Objchef);

            }
            return ChildList;



        }

        public List<Chef> AddNewChef(List<Chef> childList)
        {
            MasterList.AddRange(childList);
            return MasterList;
        }

        public void Deletechef(int Id)
        {
            Chef delchef = MasterList.FirstOrDefault(x => x.code == Id);
            MasterList.Remove(delchef);
        }

        public (int index, Chef Obj) IndexPositionandObject()
        {
            Chef Objchef = new Chef();

            Console.WriteLine("Enter First Name");
            Objchef.Name = (Console.ReadLine());

            Console.WriteLine("Enter Age");
            Objchef.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Code");
            Objchef.code = int.Parse(Console.ReadLine());

            Console.WriteLine("Plz enter index number.");
            int index = int.Parse(Console.ReadLine());

            return (index, Objchef);
        }

        public void InsertChef(int index, Chef chef)
        {
            MasterList.Insert(index, chef);
        }

        public  (int index, List<Chef> objs) AddNewListofIndex()
        {
            int index = 0;
            Console.WriteLine("Enter Index");
            int.TryParse(Console.ReadLine(), out var G);
            index = G;

            List<Chef> SecList = new List<Chef>();

            for (int i = 0; i < index ; i++)
            {
                Chef Objchef = new Chef();

                Console.WriteLine("Enter First Name");
                Objchef.Name = (Console.ReadLine());

                Console.WriteLine("Enter Age");
                Objchef.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Code");
                Objchef.code = int.Parse(Console.ReadLine());

                
                SecList.Add(Objchef);
            }

            return (index,SecList);

        }

        public void InsertChefList(int index,List<Chef> chef)
        {
          //  MasterList.InsertRangeAt(index, SecList);
            MasterList.AddRange(chef);
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
