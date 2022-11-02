using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    interface IChefService
    {
        List<Chef> AddNewChef(List<Chef> NewChefList);

      void  Deletechef(int Id);

        List<Chef> UserInput();

        void  InsertChef(int index, Chef chef);

        (int index, Chef Obj) IndexPositionandObject();

        public (int index, List<Chef> objs) AddNewListofIndex();



       void Display();
    }
}
