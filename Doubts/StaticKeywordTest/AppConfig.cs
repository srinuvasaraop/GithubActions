namespace Doubts.StaticKeywordTest;

public class AppConfig
{
    private static string ApplicationName { set;get;}

    static void Main(string[] args)
    {
        ApplicationName = "Srinivas";
        Console.WriteLine($"Helo boss {ApplicationName}");
    }
}