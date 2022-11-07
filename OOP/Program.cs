using OOP.Abstraction;
using OOP.InCapsulation;
using OOP.Inheritance;
using OOP.ObjInitialize;
using System;
using System.Collections.Generic;
using OOP.Abstraction.EnCapsulation;

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
            //dump.Eat = "Animal Eating";
            //dump.Eat1 = "Animal Eating1";
            //dump.Eat2 = "Animal Eating2";
            //dump.Eat3 = "Animal Eating3";
            //dump.Eat4 = "Animal Eating4";
            //dump.Eat5 = "Animal Eating5";

            //Dump dump2 = new Dump(dump);
            //Console.WriteLine(dump2.Eat);
            //Console.WriteLine(dump2.Eat1);
            //Console.WriteLine(dump2.Eat2);
            //Console.WriteLine(dump2.Eat3);
            //Console.WriteLine(dump2.Eat4);
            //Console.WriteLine(dump2.Eat5);
            ////By using Constructors
            //Dump dump1 = new Dump();
            //Console.WriteLine(dump1.Eat);






            //Animal AnimalObj = new Animal("E", "R", "L");
            //Console.WriteLine(AnimalObj.E);
            //Console.WriteLine(AnimalObj.R);
            //Console.WriteLine(AnimalObj.L);

            //AnimalObj.AnimalEat();
            //AnimalObj.AnimalRun();
            //AnimalObj.AnimalLooking();
            //IStudent student = new NewStu();
            //student.StudentPass();

            //IStaff StaffObJNew = new NewStu();
            //StaffObJNew.StaffAttendance();

            //Cuboid objCub  = new Cuboid();

            //(int Length, int Width) = objCub.TakingInputsFromTheUser();

            //Cuboid objcub = new Cuboid(Length, Width);

            //Console.WriteLine(objcub.Area());

            //Console.WriteLine(objcub.parameter());

            //OverrideingP ObjOver = new OverrideingP();

            //OverLoading ObjLoad = new OverLoading(1,2);
            //OverLoading ObjLoadOther = new OverLoading();
            //ObjLoad.Add();
            //ObjLoadOther.Add(1, 1.0f, 2.0f);
            //ObjLoadOther.Add(1,2f,2.4f);
            //ObjLoadOther.Add(1.0,2.0,2.4f);

            //IStore StoreObj = new Store();
            //StoreObj.StoreClosed();

            //IStore StoreObj1 = new Store();
            //StoreObj1.StoreOpen();

            //Employee employee = new Employee();
            //employee.GetEmpId();

            //employee.EmployeeId1 = 1;

            //Console.WriteLine(employee.EmployeeId1); 

            // Take input from user and create object

           // ChefRepo Objchef3 = new ChefRepo();

           // Objchef3.isCheck();

            
           //IChefService chefRepo = new ChefRepo();
           // var result = chefRepo.UserInput();

           // chefRepo.AddNewChef(result);

           // (int i, Chef chef) = chefRepo.GetIndexPositionandObject();

            //chefRepo.InsertChef(i, chef);
            // chefRepo.AddNewListofIndex();
            //chefRepo.Contains()\

            // Fist of all create the object of our Repo Class, which have many functions in it.
            ChefRepo chefRepoObj = new ChefRepo();

            // Second, Then by object (chefRepoObj) we call the function to create object (ObjectCreate()), which is returing an object.
            Chef newChef = chefRepoObj.ObjectCreate();

            // Third, Then we add object into our Master list  by calling AddNewObject Function.
            chefRepoObj.AddNewObject(newChef);

           
            
            int Salary;
            Console.WriteLine("Enter Salary");
           
            Salary = int.Parse(Console.ReadLine());
            Chef K = chefRepoObj.GetBaseonID(Salary);
            Console.WriteLine(K.Name);
            Console.WriteLine(K.Age);
            Console.WriteLine(K.code);
            Console.WriteLine(K.salary);
            

               

            //chefRepo.Display();


           // IStudentCap studentService = new StudentCapRepo();

          //
            //string[] animal = { "Cow", "Goat", "Horse" };

            //List<string> animalList = new List<string>();

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine($"Please Enter {i} Name:");

            //    animalList.Add(Console.ReadLine());

            //}

            //animalList.AddRange(animal);

            //foreach (string item in animalList)
            //{
            //    Console.WriteLine(item);

            //}


            List<int> TableList = new List<int>(4);

            int x, y;

            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine("Please Enter First Value");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Second");
                y = int.Parse(Console.ReadLine());

               int Result1 = x * y;

                TableList.Add(Result1);
            }
            foreach (var item in TableList)
            {
                Console.WriteLine($"Result is: {item}");
            }

            int F, S, T;

            Console.WriteLine("Please Enter First Value");
            F = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Second Value");
            S = int.Parse(Console.ReadLine());

            T = F;
            F = S;
            S = T;

            Console.WriteLine($"Result is: {F}{S}");

         








        }
    }
}