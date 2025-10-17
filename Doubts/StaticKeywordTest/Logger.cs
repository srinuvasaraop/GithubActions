namespace Doubts.StaticKeywordTest;

public class Logger
{
    public static string LogFilePath;

    // ✅ Static constructor - runs only once, automatically
    static Logger()
    {
        Console.WriteLine("Static constructor called.");
        LogFilePath = "/logs/app_log.txt";
    }

    public static void WriteLog(string message)
    {
        Console.WriteLine($"Writing to {LogFilePath}: {message}");
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Program started.");

        // ✅ Accessing static field for the first time triggers static constructor
        Console.WriteLine($"Log file is located at: {Logger.LogFilePath}");

        // ✅ Second access does not re-run static constructor
        Logger.WriteLog("Application started.");

        Console.WriteLine("Program ended.");
    }
}