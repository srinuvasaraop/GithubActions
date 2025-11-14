namespace Doubts;

public class Lamda3
{
    static void Main(string[] args)
    {
        Func<int,int,int> SumofTwo= (x, y) => x + y;
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine(SumofTwo(x,y));
    }
}