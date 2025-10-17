namespace Tasks;
/*Create a class called Book with the following properties:
Title (string)
Author (string)
Pages (int)
Add a constructor to the Book class that takes values for all properties.
    Create 2 or more instances of the Book class in your Main method.
    Display details of each book using Console.WriteLine.*/

public class Task3
{
    string Title;
    string Author;
    int Pages;
    
    Task3(string input, string output, int page)
    {
        Title=input;
        Author=output;
        Pages=page;
    }
    public static void Main(string[] args)
    {
        Task3 task3 = new Task3("Hi","chetanbatath",7);
        Task3 task4 = new Task3("Hello","babai",77);
        
        Console.WriteLine($"{task3.Title}\n{task3.Author}\n{task3.Pages}\n");
        Console.WriteLine($"{task4.Title}\n{task4.Author}\n{task4.Pages}\n");
        
    }
}