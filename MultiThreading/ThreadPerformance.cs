using System.Diagnostics;

namespace MultiThreading;

public class ThreadPerformance
{
    public static void Increment1()
    {
        long count1 = 0;
        for (long i= 0; i <= 1000; i++)
            count1++;
        Console.WriteLine("Increment1 Value is "+count1);
    }
    public static void Increment2()
    {
        long count2 = 0;
        for (long i= 0; i <= 1000; i++)
            count2++; 
        Console.WriteLine("Increment2 Value is "+count2);
    }
    public static void Main(string[] args)
    {
        //Here we used without thereading concept to execute test cases
        Stopwatch stopwatch = new();
        stopwatch.Start();
        Increment1();
        Increment2();
        stopwatch.Stop();
        Console.WriteLine(stopwatch.ElapsedMilliseconds);
        
        // So let's mitigate this by using MutliThreaded concept
        Stopwatch stopwatch2 = new();
        stopwatch2.Start();
        Thread t1= new Thread(Increment1);
        Thread t2 = new Thread(Increment2);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        stopwatch2.Stop();
        Console.WriteLine(stopwatch2.ElapsedMilliseconds);
    }
}
