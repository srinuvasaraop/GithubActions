namespace Doubts;

public class LamdaTest
{
    static void Main(string[] args)
    {
        Func<int,int,int> value=(a,b)=> a + b;
        Console.WriteLine(value(10,20));
    }
}