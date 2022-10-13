using System;
namespace OOP.ObjInitialize
{
    class Overriding : OverrideingP
    {
        public int LengthR, WidthR;
        public override int Area(int LengthR, int WidthR)
        {

            return LengthR * WidthR;

        }
               
    }
}
