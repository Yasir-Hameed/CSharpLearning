using System;
namespace OOP.Inheritance
{
    class OverLoading
    {
        int a, b;
        public OverLoading()
        {

        }

        public OverLoading(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Add()
        {
            return a + b;
        }
        public int Add(int a,int b, int c)
        {
            return a + b + c;
        }
        public float Add(int a, float b, float c)
        {
            return a + b + c;
        }
        public double Add(double a,double b,float c)
        {
            return a + b + c;
        }
    }
}
