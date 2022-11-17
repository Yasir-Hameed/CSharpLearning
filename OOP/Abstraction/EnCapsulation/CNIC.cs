using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    class CNIC
    {
        string CardNo;
        public void ValidateCNIC()
        {
            Console.WriteLine("Please EnterYour CNIC");
            CardNo = Console.ReadLine();

            if (CardNo.Length != 15)
            {
                Console.WriteLine("Please Enter 15 Characters in CNIC");
                CardNo = Console.ReadLine();

            }
        }
        
    }
}
