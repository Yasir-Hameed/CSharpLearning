using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
   public  class FunctionsLearning
    {
        static void Main()
        {
            FunctionsLearning Object = new FunctionsLearning();

            #region Functions of int Types

            Object.NoReturnNoInput();

            int sumResult = Object.ReturnWithNoInput();
            Console.WriteLine($"Sum of a and B is: {sumResult}");


            int sumRes = Object.ReturnWithInput(10, 15);
            Console.WriteLine($"Sum of a and B is: {sumRes}");

            Object.NoReturnWithInput(10, 20);

            #endregion


            #region Functions of String Types

            string Firstname, Lastname, Fullname;
            Console.WriteLine("Please Enter First Name");
            Firstname = (Console.ReadLine());
            Console.WriteLine("Please Enter Last Name");
            Lastname = (Console.ReadLine());
           
            Fullname = Object.StringInputwithReturn(Firstname, Lastname);
            Console.WriteLine($"Fullname: {Fullname}");

            string firstName, lastName;
            Console.WriteLine("Please Enter First Name");
            firstName = (Console.ReadLine());
            Console.WriteLine("Please Enter Last Name");
            lastName = (Console.ReadLine());
           
            Object.StringInputWithNoReturn(firstName, lastName);

            Fullname = Object.StringNoInputWithReturn();
            Console.WriteLine($"Fullname: {Fullname}");

            Object.StringNoInputNoReturn();

            Object.StringNoInputWithReturn();

            

            #endregion

        }


        /// <summary>
        /// We will use Void key for No Return and No Input due to no parameters in ()
        /// </summary>
        public void NoReturnNoInput()
        {
            int a = 10, b = 5, sum;
            sum = a + b;
            Console.WriteLine($"Sum of a and B is: {sum}");
        }

        /// <summary>
        /// We will use data types i-e int,string,float etc whcich will Return without Input  due to no parameters in ()
        /// </summary>
        /// <returns>Return Result in int</returns>
        public int ReturnWithNoInput()
        {
            int a = 10, b = 5, sum;
            sum = a + b;
            return sum;
        }


        /// <summary>
        /// We will use data types i-e int,string,float etc whcich will Return value with Input in parameter ()
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns></returns>
        public int ReturnWithInput(int firstValue, int secondValue)
        {
            int sum = firstValue + secondValue;
            return sum;
        }

        /// <summary>
        ///  We will use void whcich will Return value with Input in parameter ()
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        public void NoReturnWithInput(int firstValue, int secondValue)
        {
            int sum = firstValue + secondValue;
            Console.WriteLine($"Total Sum is: {sum}");
        }

        ///String Function///

        public void StringNoInputNoReturn()
        {
            string Firstname, Lastname;

            Console.WriteLine("Please Enter First Name");
            Firstname = (Console.ReadLine());
            Console.WriteLine("Please Enter Last Name");
            Lastname = (Console.ReadLine());
            Console.WriteLine("Full Name" +Firstname+Lastname);
        }
        public string StringInputwithReturn(string Firstname,string Lastname)
        {
            string FullName;
            FullName = string.Concat(Firstname + Lastname);
            return FullName;
        }
        public string StringNoInputWithReturn()
        {

            string firstName = "Yasir";
            string lastName = "Hameed";
            string fullName = firstName + " " + lastName;
            return fullName;

        }

        public void StringInputWithNoReturn(string firstName, string lastName)
        {
           Console.WriteLine($"Full Name is:  ,{ firstName},{ lastName}");
        }
    }

}
