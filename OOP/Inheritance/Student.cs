using OOP.Abstraction;

namespace OOP
{
    public class Student : IStudent
    {
        int studentId, studentAge; string studentSex;

        public void GetStudentInfo()
        {

        }

        public void Ship()
        {
            System.Console.WriteLine("TCS");
            System.Console.WriteLine("LCS");
            System.Console.WriteLine("OCS");
        }

        public void StudentFail(string condition)
        {
            throw new System.NotImplementedException();
        }

        public void StudentPass()
        {
            throw new System.NotImplementedException();
        }
    }
}