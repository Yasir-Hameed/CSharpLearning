using System;
namespace OOP.Inheritance
{
    public class Rectangle
    {
       public int LengthR, WidthR;
        public int Area()
        {

            return LengthR * WidthR;

        }
     
        public int parameter()
        {
            return 2 * (LengthR * WidthR);
        }

        public (int,int) TakingInputsFromTheUser()
        {
            int Length, Width;
            Console.WriteLine("Please Enter the Length.");
            Length = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please Enter the Width.");
            Width = int.Parse(Console.ReadLine());

            return (Length, Width);

        }
    }
}
