namespace Tasks;



public class Task1
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name:");
        string name = Console.ReadLine();
        Console.Write("Enter your age:");
        bool bl=int.TryParse(Console.ReadLine(), out int age);
        if (bl)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old!");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for age.");
        }
        
    }
}