using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    class StudentMain
    {
       public static string errorMessage;
        static void Main()
        {
            try
            {
                #region Student Implementation

                //IStudentService StudentObj1 = new RepStudentService();

                ////Student Stud = StudentObj1.ObjectStudent();

                ////StudentObj1.AddNewStudent(Stud);

                //var NewList = StudentObj1.AddNewList();


                //StudentObj1.AddStudentList(NewList);


                //int Id;
                //Console.WriteLine("Enter Student Id to Delete");
                //Id = int.Parse(Console.ReadLine());
                //StudentObj1.DelStudent(Id);

                //StudentObj1.Display();

                #endregion

                bool flag = false;
                do
                {
                    Console.WriteLine("Please EnterYour CNIC");
                    string CardNo = Console.ReadLine();


                    if(LengthValidation(CardNo) && HifenValidation(CardNo) && CheckHifenIndex(CardNo) && AcceptIntNotString(CardNo))
                    {
                        Console.WriteLine("Thanks for enter Valid CNIC!");
                    }
                    else
                    {
                        Console.WriteLine($"Please Enter Valid CNIC! + {errorMessage}" );
                    }
                   
                    flag = ValidOption();
                }
                while (flag);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} Error!");
                Console.WriteLine($"{ex.StackTrace} Error!");
                Console.WriteLine($"{ex.InnerException} Error!");
            }
        }
       
        
        
        
        
        
        
        
        public static bool ValidOption()
        {
            bool flag;

        ValidOption:
            Console.WriteLine("Do You want to continue? If yes then Press Y, If No then Press N");
            string skipOrCont = Console.ReadLine();
            if (skipOrCont.Contains('y') || skipOrCont.Contains('Y'))
                flag = true;
            else if (skipOrCont.Contains('N') || skipOrCont.Contains('n'))
                flag = false;
            else
            {
                Console.WriteLine("Please Enter Valid Option!");
                goto ValidOption;
            }


            return flag;

        }

        public static bool HifenValidation(string CardNo)
        {

            bool flag = false;
            string[] splitCNIC = CardNo.Split('-');

            if (splitCNIC.Length == 3)
                flag = true;

            if (!flag)
                errorMessage = "Hifen is missing";

            return flag;
        }

         public static bool LengthValidation(string CardNo)
         {
            bool flag = false;
            
            if (CardNo.Length == 15)
                flag = true;

            if (!flag)
                errorMessage = "Length is Not Valid";

            return flag;
         }
       
        public static bool CheckHifenIndex(string CardNo)
        {
            bool flag = false;
            
            if(CardNo[5] == '-' && CardNo[13] == '-')
            {
                flag = true;
            }

            if (!flag)
                errorMessage = "Hifen Position is Not Valid";

            return flag;
        }

      public static bool  AcceptIntNotString(string CardNo)
       {
            bool flag = false;

            var splitHifen = CardNo.Split('-');

            string newCardNo = string.Concat(splitHifen);

            foreach (var item in newCardNo)
            {
                if (Char.IsDigit(item))
                {
                    flag = true;
                }               
                else
                {
                    flag = false;
                    errorMessage = "Only Accept Digit.";

                    break;
                }
            }

            return flag;
        }




    }
}
