using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP.Abstraction.EnCapsulation
{
    class chefrepo : Ichef
    {
        List<Chef> ChefList = new List<Chef>();

        public List<Chef> UserInput()
        {
            int UserInput = 0;
            Console.WriteLine("Enter Number of Chefs");
            UserInput = int.Parse(Console.ReadLine());

            List<Chef> NewChefList = new List<Chef>();

            for (int i = 0; i < UserInput; i++)
            {
                Chef Objchef = new Chef();

                Console.WriteLine("Enter First Name");
                Objchef.Name = (Console.ReadLine());

                Console.WriteLine("Enter Age");
                Objchef.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Code");
                Objchef.code = int.Parse(Console.ReadLine());

                NewChefList.Add(Objchef);

            }
            return NewChefList;

         

        }

        public void AddNewChef(List<Chef> NewChefList)
        {
            ChefList.AddRange(NewChefList);
        }

        public void Deletechef(int Id)
        {
                Chef delchef = ChefList.FirstOrDefault(x => x.code == Id);
                ChefList.Remove(delchef);

               
        }

    }
}
