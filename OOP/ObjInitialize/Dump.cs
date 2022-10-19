using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ObjInitialize
{
    class Dump
    {
       public string Eat;
       public string Eat1;
       public string Eat2;
       public string Eat3;
       public string Eat4;
       public string Eat5;
        public Dump MyObj { get; set; }

        public Dump()
        {

        }
        public Dump(string eat)// "animal eating"
        {
            Eat = eat;
        }

        public Dump(Dump obj)
        {
            MyObj = obj;
        }

    }
}
