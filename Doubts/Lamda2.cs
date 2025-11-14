namespace Doubts;
/// <summary>
/// Write a lambda that checks if a number is even.
/// </summary>
public class Lamda2
{
    public int GetEvenNumber(int number)
    {
        return number % 2;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number");
            Lamda2 l = new Lamda2();
          //  Console.WriteLine(l.GetEvenNumber(int.Parse(Console.ReadLine())));
            int input = int.Parse(Console.ReadLine());
            int data = l.GetEvenNumber(input);
            switch (data)
            {
                case 0:
                    Console.WriteLine("This is even number");
                    break;
                default:
                    Console.WriteLine("This is odd number");
                    break;
            }
    }
}