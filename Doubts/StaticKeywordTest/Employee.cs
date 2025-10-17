namespace Doubts.StaticKeywordTest;

public class Employee
{
    public static int TotalEmployees;

    private Employee()
    {
        TotalEmployees++;
    }
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        Console.WriteLine(TotalEmployees);
        Employee employee1 = new Employee();
        Console.WriteLine(TotalEmployees);
    }
}