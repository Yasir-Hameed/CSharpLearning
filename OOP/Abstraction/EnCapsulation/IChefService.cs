using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Abstraction.EnCapsulation
{
    interface IChefService
    {

        //Object cfreate of Chef

        

        // Add object to List of Chef
       

        // Get List of all object

        //public List<Chef> GetListofObject();


        // Get Object from List based on Salary

      
        void Display();

        #region Without Parameterized Functions

        public Chef ObjectCreate();
        (int index, Chef Obj) GetIndexPositionandObject();
        public (int index, List<Chef> objs) AddNewListofIndex();
        List<Chef> UserInput();


        #endregion

        #region Parameterized Functions 

        #region Single Parmeterized Functions
        public List<Chef> AddNewObject(Chef chef);
        public Chef GetBaseonID(int sal);
        List<Chef> AddNewChef(List<Chef> NewChefList);


        #endregion

        #region Multiples Parmeterized Functions



        #endregion
        void InsertChef(int index, Chef chef);

        #region Optional Parmeterized Functions


        #endregion

        #endregion
    }
}
