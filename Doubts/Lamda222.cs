namespace Doubts;

public class Lamda222
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the number");
        int input = int.Parse(Console.ReadLine()!);
        Func<int,int> isEven=(x) => x%2;
        int result = isEven(input);
        switch (result)
        {
            case 0:
                Console.WriteLine("The number is even");
                break;
            default:
                Console.WriteLine("The number is not even");
                break;
        
    }
    }
}