namespace APILearning.Models.StudentModels
{
    public class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Mail { get; set; }
        public int Marks { get; set; }
  
        public int teacherId { get; set; }
        public Teacher teacher { get; set; }

    }
}