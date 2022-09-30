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
            HelloWorld();

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

        #endregion
    }
}

