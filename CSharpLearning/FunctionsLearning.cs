using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    public class FunctionsLearning
    {
        //static void Main()
        // {
        //     FunctionsLearning Object = new FunctionsLearning();

        //     #region Functions of int Types Definition

        //     //Object.NoReturnNoInput();

        //     //int sumResult = Object.ReturnWithNoInput();
        //     //Console.WriteLine($"Sum of a and B is: {sumResult}");


        //     //int sumRes = Object.ReturnWithInput(10, 15);
        //     //Console.WriteLine($"Sum of a and B is: {sumRes}");

        //     //Object.NoReturnWithInput(10, 20);




        //     #endregion


        //     //#region Functions of String Types

        //     //string Firstname, Lastname, Fullname;
        //     //Console.WriteLine("Please Enter First Name");
        //     //Firstname = (Console.ReadLine());
        //     //Console.WriteLine("Please Enter Last Name");
        //     //Lastname = (Console.ReadLine());

        //     //Fullname = Object.StringInputwithReturn(Firstname, Lastname);
        //     //Console.WriteLine($"Fullname: {Fullname}");

        //     //string firstName, lastName;
        //     //Console.WriteLine("Please Enter First Name");
        //     //firstName = (Console.ReadLine());
        //     //Console.WriteLine("Please Enter Last Name");
        //     //lastName = (Console.ReadLine());

        //     //Object.StringInputWithNoReturn(firstName, lastName);

        //     //Fullname = Object.StringNoInputWithReturn();
        //     //Console.WriteLine($"Fullname: {Fullname}");

        //     //Object.StringNoInputNoReturn();

        //     //Object.StringNoInputWithReturn();

        //     int[] array = arrayValues();

        //     int maxValue = Object.ReturnMaxValue(array);

        //     string evenOrOdd = Object.maxNumOddorEven(maxValue);

        //     //Console.WriteLine(evenOrOdd);

        //     CombinedProgram();

        //     //#endregion

        // }

        //--------------------------Functions------------------------

        #region Functions of Ints Implementations

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
        /// Taking Inputs in Array
        /// </summary>
        /// <returns></returns>
        public static int[] arrayValues()
        {
            int sizeOfArray; int[] array; int count = 0;

            Console.WriteLine("Enter Size of Array");
            sizeOfArray = int.Parse(Console.ReadLine());

            array = new int[sizeOfArray];
            Console.WriteLine("Enter Numbers");


            foreach (var item in array)
            {
                array[count] = int.Parse(Console.ReadLine());
                Console.WriteLine($"Array is: {array[count]}");
                count++;

            }
            return array;
        }

        /// <summary>
        /// To Find Max Value from an Array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int ReturnMaxValue(int[] array)
        {
            int max = 0, count = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"Item is: {item}");
                if (max < array[count])
                {
                    max = array[count];
                    count++;
                }

            }
            return max;
        }

        /// Find Max Number is Even or Odd///
        /// 

        public string maxNumOddorEven(int max)
        {
            string evenOrOdd;

            if (max % 2 == 0)
            {
                evenOrOdd = $"Max Number is Even: + {max}";
            }
            else
            {
                evenOrOdd = $"Max Number is Odd: + {max}";
            }
            return evenOrOdd;
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

        public static void CombinedProgram()
        {
            FunctionsLearning functionsLearning = new FunctionsLearning();
            int[] array = arrayValues();

            int maxValue = functionsLearning.ReturnMaxValue(array);

            string evenOrOdd = functionsLearning.maxNumOddorEven(maxValue);

            Console.WriteLine(evenOrOdd);
        }

        #endregion


        #region functions of Strings
        public void StringNoInputNoReturn()
        {
            string Firstname, Lastname;

            Console.WriteLine("Please Enter First Name");
            Firstname = (Console.ReadLine());
            Console.WriteLine("Please Enter Last Name");
            Lastname = (Console.ReadLine());
            Console.WriteLine("Full Name" + Firstname + Lastname);
        }
        public string StringInputwithReturn(string Firstname, string Lastname)
        {
            string FullName;
            FullName = string.Concat(Firstname, Lastname);
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

        public static void ArrayTask()
        {
            int flag = 0;
            string[] array = { "Yasir", "Hameed", "Khan" };
            int pos = 1;
            string val = "Asif";

            string[] newArray = new string[array.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if(flag ==0)
                {
                    if (i == pos)
                    {
                        flag = 1;
                        newArray[i] = val;
                        i--;
                    }
                }
                else
                {
                    newArray[i] = array[i];
                }
            }

            foreach (var item in newArray)
            {
                Console.Write(item);
            }
        }



        #endregion

        #region Methods of String



        #endregion

    }

}
