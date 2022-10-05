using System;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArithmaticalOperations();
            // AreaMeasurement();
            // InterestRate();
            // Swapping();
            // Admission();
            // MaximumNumber();
            // MaximumNumberWithNestedIf();
            // EvenoOddNumber();
            // StudentGrades();
            // CalculateProfitandLoss();
            // HelloWorld();
            // HelloWorldfor();
            // HelloWorldDoWhile();
            // Table();
            // Factorial();
            // FactorialSelf();
            // series();
            // EvenSum();
            //  PrintArray();
            // OddNumberArray();
            // EvenSumandOddSum();
            // ShortTypeEvenSumandOddSum();
            FunctionsLearning Function = new FunctionsLearning();
            Function.NoReturnNoInput();



        }

        #region IF-Else Programs

        /// <summary>
        /// Write a program that takes inputs from the user and performs All mathmetical Operations.
        /// </summary>
        public static void ArithmaticalOperations()
        {
            int firstNumber, secondNumber, dividend, divisor;

            Console.WriteLine("Please insert 1st Number");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert 2nd Number");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Dividend");
            dividend = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Divisor");
            divisor = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum is:{firstNumber + secondNumber}");
            Console.WriteLine($"Min is:{firstNumber - secondNumber}");
            Console.WriteLine($"div is:{firstNumber / secondNumber}");
            Console.WriteLine($"Mul is:{firstNumber * secondNumber}");
            Console.WriteLine($"Mod is:{firstNumber % secondNumber}");

            Console.WriteLine($"Your Quotient is:{dividend / divisor}");
            Console.WriteLine($"Your Remainder is:{dividend % divisor}");
        }

        /// <summary>
        /// Area of Different Shapes i-e Triangle,Circle and Rectangle
        /// </summary>
        public static void AreaMeasurement()
        {
            float bas, height, width, rad;
            Console.WriteLine("Please Enter base Values");
            bas = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter height Value");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Width Value");
            width = float.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Radius Value");
            rad = float.Parse(Console.ReadLine());



            Console.WriteLine($"Total Area of Triangle is:{1.5 * bas * height}");
            Console.WriteLine($"Total Area of Rectangle is:{ width * height}");
            Console.WriteLine($"Total Area of Circle is{22.7 * 2 * rad}");

        }

        /// <summary>
        /// To Calculate Interest or ROI
        /// </summary>
        public static void InterestRate()
        {
            int income, month;
            Console.WriteLine("Enter Your Income");
            income = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No.of Months");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine($"Total Turnover {income * .07 / month}");
        }


        /// <summary>
        /// Swap the Values
        /// </summary>
        public static void Swapping()
        {
            int firstNum, secondNum, temp = 0;
            Console.WriteLine("Enter First Number");
            firstNum = int.Parse(Console.ReadLine()); //50
            Console.WriteLine("Enter Second Number"); //100
            secondNum = int.Parse(Console.ReadLine());

            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;
            Console.WriteLine($"Swap Result is:{firstNum}{Environment.NewLine}{secondNum}");

        }

        /// <summary>
        /// Input from User against three Courses and on basis of Avg Score Decide Admission Granted or Not
        /// </summary>
        public static void Admission()
        {
            int Maths, English, Urdu, AvgScore;

            Console.WriteLine("Enter Maths Score");
            Maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter English Score");
            English = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Urdu Score");
            Urdu = int.Parse(Console.ReadLine());
            AvgScore = ((Maths + English + Urdu) / 3);
            Console.WriteLine($"Avg Score:{AvgScore}");

            if (AvgScore >= 60 && AvgScore <= 100)
            {
                Console.WriteLine("Admission Granted");
            }
            else
            {
                Console.WriteLine("Not Qualified");
            }
        }

        /// <summary>
        /// Take Input Three Numbers from User and identify Greater Number
        /// </summary>
        public static void MaximumNumber()
        {
            int firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Please Enter First Number");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number");
            thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine($"firstNumber is Greater {firstNumber}");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine($"secondNumber is Greater {secondNumber}");
            }
            else
            {
                Console.WriteLine($"ThirdNumber is Greater{thirdNumber}");
            }

        }

        /// <summary>
        /// Find Maximum Number from three numbers via of else
        /// </summary>
        public static void MaximumNumberWithNestedIf()

        {
            int firstNumber, secondNumber, thirdNumber;
            Console.WriteLine("Please Enter First Number");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number");
            thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine($"firstNumber is Greater {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Third Number is Greatr{thirdNumber}");
                }
            }
            else
            {
                if (secondNumber > thirdNumber)
                {
                    Console.WriteLine($"secondNumber is Greater{secondNumber}");
                }
                else
                {
                    Console.WriteLine($"Third Number is Greatr{thirdNumber}");
                }
            }
        }

        /// <summary>
        /// Take input from user and identify either no. is even or odd via using if else
        /// </summary>
        public static void EvenoOddNumber()
        {
            int Number;
            Console.WriteLine("Enter Desired Number");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine($"Number is Even {Number}");

            }
            else
            {
                Console.WriteLine($"Number is Odd{Number}");
            }

        }

        /// <summary>
        /// Find Grades of Student via If and if else
        /// </summary>
        public static void StudentGrades()
        {
            int score;
            Console.WriteLine("Enter Your Score");
            score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine($"Grade A{score}");
            }
            else if (score >= 80)
            {
                Console.WriteLine($"Grade is B{score}");
            }
            else if (score >= 70)
            {
                Console.WriteLine($"Grade is C{score}");
            }
            else
            {
                Console.WriteLine($"Fail {score}");
            }
            {

            }
        }

        /// <summary>
        /// calculate Profit and Loss via Float 
        /// </summary>
        public static void CalculateProfitandLoss()
        {
            float salePrice = 0F, purchasePrice = 0F, difference = 0;


            Console.WriteLine($"Enter Puchase Price{purchasePrice}");
            purchasePrice = float.Parse(Console.ReadLine());
            Console.WriteLine($"Enter Sale Price{salePrice}");
            salePrice = float.Parse(Console.ReadLine());

            difference = (salePrice - purchasePrice);

            if (difference > 0)
            {
                Console.WriteLine($"Profit {difference}");
            }
            else
            {
                Console.WriteLine($"Loss {difference}");
            }
        }

        #endregion

        #region Loops Programms

        /// <summary>
        /// Print Hello World on basis of user input via while loop
        /// </summary>
        static void HelloWorld()

        {
            int i = 0, num = 0;
            Console.WriteLine("Insert number to repeat");
            num = int.Parse(Console.ReadLine());
            while (i <= num)
            {
                Console.WriteLine("Hello World");
                i++;

            }

        }

        /// <summary>
        /// Print Hello World via For Loop
        /// </summary>
        static void HelloWorldfor()
        {
            int i, num;
            Console.WriteLine("Insert Number to Repeat");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("Hello World");
            }
        }

        /// <summary>
        /// Use do While Loop
        /// </summary>
        static void HelloWorldDoWhile()
        {
            int i = 1, num;
            Console.WriteLine("Insert Number to Repeat");
            num = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Hello World");
                i++;
            }
            while (i <= num);
        }

        /// <summary>
        /// Insert Table through initial and endValues
        /// </summary>
        static void Table()
        {
            int initialValue, table, endValue;

            Console.WriteLine("Insert Number of Required Table");
            table = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert initialValue");
            initialValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert end Number");
            endValue = int.Parse(Console.ReadLine());

            while (initialValue <= endValue)
            {
                Console.WriteLine($"{table}*{initialValue} = {table * initialValue}");
                initialValue++;
            }

        }

        /// <summary>
        /// Factorial Calculation
        /// </summary>
        static void Factorial()
        {
            int initialValue = 1, userInput, result = 1;

            Console.WriteLine("Insert UserInput");
            userInput = int.Parse(Console.ReadLine());
            while (initialValue <= userInput)
            {
                result = result * initialValue;
                initialValue++;
            }
            Console.WriteLine($"Factorial = {result}");
        }

        /// <summary>
        /// Factorial By Self
        /// </summary>
        static void FactorialSelf()
        {
            int initialValue = 1, userinput, result = 1;

            Console.WriteLine("Enter Input");
            userinput = int.Parse(Console.ReadLine());

            while (initialValue <= userinput)
            {
                result = result * initialValue;
                initialValue++;
            }
            Console.WriteLine($"Seiries is: {result}");
        }

        static void series()
        {
            float firstValue = 1, sumValue = 1, input;

            Console.WriteLine("Enter Input");
            input = float.Parse(Console.ReadLine());

            while (firstValue <= input)
            {
                if (firstValue % 2 == 0)
                {
                    sumValue = sumValue + sumValue * 1 / firstValue;
                }
                firstValue++;
            }
            Console.WriteLine($"Print Sum Value{sumValue}");



            #endregion
        }

        /// <summary>
        /// Count the Even sum and Odd Sum
        /// </summary>
        static void EvenSum()
        {
            int firstNum = 1, userInput, evenSum = 0, oddSum=0;

            Console.WriteLine("Please Enter User Input");
            userInput = int.Parse(Console.ReadLine());

            while (firstNum <= userInput)
            {
                if (firstNum % 2 == 0)
                {
                    evenSum = evenSum + firstNum;
                }
                else
                {
                    oddSum = oddSum + firstNum;
                }
            
               firstNum ++;
            }
            Console.WriteLine($"EvenSum is: {evenSum}");
            Console.WriteLine($"OddSum is: {oddSum}");

        }

        /// <summary>
        /// Use of Foreach Loop
        /// </summary>
        static void PrintArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Identify Even Numbers via foreach loop
        /// </summary>
        static void OddNumberArray()
        {
            int sizeOfArray, count = 0;  int[] arrayName;
           
            Console.WriteLine("Please Enter Your Numbers");
            sizeOfArray = int.Parse(Console.ReadLine());

            arrayName = new int[sizeOfArray];

            Console.WriteLine($"Plz Enter Elements");

            foreach (var item in arrayName)
            {
                arrayName[count] = int.Parse(Console.ReadLine());
                count++;
            }

            foreach (var item in arrayName)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"Even Numbers{item}");
                }
            }     
        }

        /// <summary>
        /// Take input from User in Array & find sum of Even and Odd via foreach 
        /// </summary>
        static void EvenSumandOddSum()
        {
            int sizeOfArray; int[] array; int count=0, evenSum = 0, oddSum = 0;

            Console.WriteLine("Please Enter your Size of Array");
            sizeOfArray = int.Parse(Console.ReadLine());

             array = new int[sizeOfArray];
            Console.WriteLine("Please Enter your Elements");

            foreach (var item in array)
            {
                array[count] = int.Parse(Console.ReadLine());
                count++;
            }
            
            foreach (var item in array)
            {
                if(item%2==0)
                {
                    evenSum = evenSum + item;
                   
                }
                else
                {
                    oddSum = oddSum + item;
                    
                }
               
            }
            Console.WriteLine($"Sum of Odd Number is: {oddSum}");
            Console.WriteLine($"Sum of Even Numbers is: {evenSum}");
        }

        /// <summary>
        /// Short Type: Take input from User in Array & find sum of Even and Odd via foreach
        /// </summary>
        static void ShortTypeEvenSumandOddSum()
        {
            int sizeOfArray; int[] array; int count = 0, evenSum = 0, oddSum = 0;

            Console.WriteLine("Please Enter your Size of Array");
            sizeOfArray = int.Parse(Console.ReadLine());

            array = new int[sizeOfArray];
            Console.WriteLine("Please Enter your Elements");

            foreach (var item in array)
            {
                array[count] = int.Parse(Console.ReadLine());
                count++;
                
                if (item % 2 == 0)
                {
                    evenSum = evenSum + item;

                }
                else
                {
                    oddSum = oddSum + item;

                }
            }
            Console.WriteLine($"Sum of Odd Number is: {oddSum}");
            Console.WriteLine($"Sum of Even Numbers is: {evenSum}");
        }

    }

}