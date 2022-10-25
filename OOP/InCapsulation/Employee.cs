using System;

namespace OOP.InCapsulation
{
    public class Employee
    {
        private int EmpId;

        public void SetEmpId(int id)
        {
            EmpId = id;
        }

        public int GetEmpId()
        {
            return EmpId;
        }

        public int EmployeeId
        {
            set
            {
                EmpId = value;
            }
            get
            {
                return EmpId;
            }
           
        }

        public int EmployeeId1 { get; set; }

    }
}
