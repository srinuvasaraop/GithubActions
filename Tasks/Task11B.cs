namespace Tasks;

public class Task11B
{
    private int Id { set; get; }
    private string Name { set; get; }
    private string? Email { set; get; }
    private Dictionary<string, List<int>> SubjectMarks { set; get; } = new ();
    
    public Task11B(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddMarks(string subject, int marks)
    {
        if (!SubjectMarks.ContainsKey(subject))
        {
            SubjectMarks[subject]=new List<int>();
        }
        SubjectMarks[subject].Add(marks);
    }

    public void DisplayStudentReport()
    {
        Console.WriteLine($"Student ID: {Id}, Name: {Name}");

        if (SubjectMarks.Count == 0)
        {
            Console.WriteLine("  No marks available.");
            return;
        }

        int total = 0;
        int count = 0;

        foreach (var subject in SubjectMarks)
        {
            Console.Write($"  Subject: {subject.Key}, Marks: ");
            foreach (var mark in subject.Value)
            {
                Console.Write($"{mark} ");
                total += mark;
                count++;
            }
            Console.WriteLine();
        }

        int average = total / count;
        string grade = Task11A.GetGrades(average);   // Reuse logic if available from Task11A
        bool isPassed = average >= 50;

        Console.WriteLine($"  Average Marks: {average:F2}");
        Console.WriteLine($"  Grade: {grade}");
        Console.WriteLine($"  Passed: {(isPassed ? "Yes" : "No")}");
        Console.WriteLine(new string('-', 40));
    }

    static void Main(string[] args)
    {
        List<Task11B> listofstudents = new List<Task11B>()
        {
            new Task11B(1, "srinivas"),
            new Task11B(2, "mahesh"),
            new Task11B(3, "sivakanth"),
            new Task11B(4, "satyanandam"),
            new Task11B(5, "surendra")
        };
        listofstudents[0].AddMarks("Math", 85);
        listofstudents[0].AddMarks("Math", 90);
        listofstudents[0].AddMarks("English", 78);

        listofstudents[1].AddMarks("Math", 40);
        listofstudents[1].AddMarks("English", 50);

        listofstudents[2].AddMarks("Science", 95);
        listofstudents[2].AddMarks("Math", 88);

        listofstudents[3].AddMarks("English", 60);
        listofstudents[3].AddMarks("Science", 55);

        listofstudents[4].AddMarks("Math", 100);
        listofstudents[4].AddMarks("English", 98);
        listofstudents[4].AddMarks("Science", 97);
        
        foreach (var student in listofstudents)
        {
            student.DisplayStudentReport();
        }

    }
}