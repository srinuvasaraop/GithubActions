namespace Tasks;

public class Task11A
{
    private int Id { set; get; }
    private string Name { set; get; }
    private int Marks { set; get; }
    private string? Emails { set; get; }

    public Task11A(int id, string name, int marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
    public static string GetGrades(int marks) =>
        marks switch
        {
            >= 90 => "A",
            >= 80 and < 90 => "B",
            >= 70 and < 80 => "C",
            >= 60 and < 70 => "D",
            _ => "please try again"
        };

    /*public bool IsPassed(string grade)
    {
        if (grade != "please try again")
        {
            return true;
        }
        return false;
    }*/
    
    //You can write this more concisely using an expression-bodied member:
    public static bool IsPassed(string grade) => grade != "please try again";
    
    public void DisplayDetails()
    {
        string grade = GetGrades(Marks);
        Console.WriteLine($"Student Details => Id: {Id}, Name: {Name}, Marks: {Marks}, Grade: {grade}, IsPassed: {IsPassed(grade)}");
    }
    static void Main(string[] args)
    {
        var tasks = new List<Task11A>()
        {
            new Task11A(10, "Satyanandam", 20),
            new Task11A(20, "Sivakanth", 30),
            new Task11A(30, "Mahesh", 40),
            new Task11A(50, "Srinivas", 60)
        };
        foreach (var eachstudentlist in tasks)
        {
            eachstudentlist.DisplayDetails();
            Console.WriteLine(IsPassed(GetGrades(eachstudentlist.Marks)) ? "Congratulations":"Better luck next time!");
        }
    }
}


