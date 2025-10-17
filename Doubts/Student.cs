namespace Doubts;

public class Student
{
        public int RollNumber { get; set; }
        public string Name { get; set; }             // Required, not nullable
        public string? Email { get; set; }           // Optional, can be null

        public void PrintDetails()
        {
            if (Email != null)
            {
                Console.WriteLine(Email);
            }
            else
            {
                Console.WriteLine("Please enter a valid email address");
            }
            Console.WriteLine($"Roll No: {RollNumber}, Name: {Name}");
            
        }

        static void Main(string[] args)
        {
            Student student = new Student();
            student.Email = null;
            student.PrintDetails();
        }
}