namespace MultiThreading;

public class ThreadPriority
{
    static int _Count1;
    static int _Count2;
    static CancellationTokenSource _cts = new();

    public static void ThreadPriority1(object? tokenObj)
    {
        var token = (CancellationToken)tokenObj!;
        while (!token.IsCancellationRequested)
        {
            _Count1++;
        }
    }

    public static void ThreadPriority2(object? tokenObj)
    {
        var token = (CancellationToken)tokenObj!;
        while (!token.IsCancellationRequested)
        {
            _Count2++;
        }
    }

    public static void Main(string[] args)
    {
        Thread t1 = new(ThreadPriority1);
        Thread t2 = new(ThreadPriority2);

        t1.Start(_cts.Token);
        t2.Start(_cts.Token);

        // Let threads run for some time (e.g., 2 seconds)
        Thread.Sleep(2000);

        // Request cancellation instead of using Abort()
        _cts.Cancel();

        // Wait for threads to stop
        t1.Join();
        t2.Join();

        Console.WriteLine($"Count1: {_Count1}");
        Console.WriteLine($"Count2: {_Count2}");
        Console.WriteLine("Threads stopped gracefully.");
    }
}