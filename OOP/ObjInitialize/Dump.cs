﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.ObjInitialize
{
    class Dump
    {
       public string eats, runs, sees;
       public DateTime Date;

        public Dump()
        {

        }

        public Dump(String eats, String runs, String sees)
        {
            this.eats = eats;
            this.runs = runs;
            this.sees = sees;
            
        }
    }
}