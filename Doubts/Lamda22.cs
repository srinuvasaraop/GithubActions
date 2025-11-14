namespace Doubts;

public class Lamda22
{
    delegate int Lamda(int n);
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number");
        Lamda22 obj = new Lamda22();
        Lamda data = obj.GetEvenNumber;
        int result=data(int.Parse(Console.ReadLine()));
        switch (result)
        {
            case 0:
                Console.WriteLine("This is even number");
                break;
            default:
                Console.WriteLine("This is odd number");
                break;
        }
    }
    public int GetEvenNumber(int number)
    {
        return number % 2;
    }
}