using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    interface Ichef
    {
       void AddNewChef(List<Chef> NewChefList);

      void  Deletechef(int Id);

        List<Chef> UserInput();
    }
}
