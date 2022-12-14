using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Abstraction.EnCapsulation
{
    class ChefRepo : IChefService
    {
        List<Chef> MasterList = new List<Chef>();

        public Chef UserInputforSingleObject(Chef chef)
        {

            return (chef);
        }
        public bool isCheck()
        {
            bool checkage = MasterList.Exists(x => x.Age == 10);
            if (checkage)
            {
                Console.WriteLine("YOUR AGE IS 10");
            }
            return false;
        }
        public List<Chef> UserInput()
        {

            int UserInput = 0;
            Console.WriteLine("Enter Number of Chefs");
            UserInput = int.Parse(Console.ReadLine());

            List<Chef> ChildList = new List<Chef>();

            for (int i = 0; i <= UserInput; i += 2)
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

        public (int index, Chef Obj) GetIndexPositionandObject()
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

        public (int index, List<Chef> objs) AddNewListofIndex()
        {
            int index = 0;
            Console.WriteLine("Enter Index");
            int.TryParse(Console.ReadLine(), out var G);
            index = G;

            List<Chef> SecList = new List<Chef>();

            for (int i = 0; i < index; i++)
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

            return (index, SecList);

        }

        public void InsertChefList(int index, List<Chef> chef)
        {
            //  MasterList.InsertRangeAt(index, SecList);
            MasterList.AddRange(chef);
        }
        public bool Contains()
        {
            Chef Objchef2 = new Chef();
            MasterList.Add(Objchef2);


            return false;
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

        public Chef ObjectCreate()
        {
            Chef Obj3 = new Chef();
            Console.WriteLine("Enter First Name");
            Obj3.Name = (Console.ReadLine());

            Console.WriteLine("Enter Age");
            int.TryParse(Console.ReadLine(), out int val);
            Obj3.Age = val;

            Console.WriteLine("Enter Code");
            Obj3.code = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Salary");
            Obj3.salary = int.Parse(Console.ReadLine());


            return Obj3;
        }

        public List<Chef> AddNewObject(Chef chef)
        {
            MasterList.Add(chef);

            return MasterList;
        }

        public Chef GetBaseonID(int sal)
        {
            Chef chef = MasterList.FirstOrDefault(x => x.salary == sal);

            return chef;
        }

    }

}


