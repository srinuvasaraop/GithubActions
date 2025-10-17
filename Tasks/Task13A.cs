namespace Tasks;

public class Task13A
{
    public enum GenreType
    {
        Fiction, NonFiction, Science, History, Biography
    }
    public int Id{set; get;}
    public string Title{set; get;}
    public string Author{set; get;}
    public int YearPublished{set; get;}
    public double Price{set; get;}
    public GenreType Genre{set; get;}
    static void Main(string[] args)
    {
        List<Task13A> tasks = new List<Task13A>()
        {
            new Task13A{Id = 1,Title = "Crime", Author = "Srinivas", Price = 10, YearPublished = 2025,Genre=GenreType.Fiction},
            new Task13A{Id = 2,Title = "Non-crime", Author = "sivakanth", Price = 20, YearPublished = 2026,Genre = GenreType.NonFiction},
            new Task13A{Id = 3,Title = "Science", Author = "satyendra", Price = 30, YearPublished = 2027, Genre = GenreType.Science},
            new Task13A{Id = 4,Title = "Historical", Author = "Mahesh", Price = 40, YearPublished = 1990, Genre =GenreType.History },
            new Task13A{Id = 5,Title = "Biological", Author = "satyanandam", Price = 50, YearPublished = 2029, Genre = GenreType.Biography},
        };
        Dictionary<int,Task13A> taskDict = new Dictionary<int, Task13A>();
        foreach (var task in tasks)
        {
            taskDict[task.Id] = task;
        }
        foreach (var pair in taskDict)
        {
            var book = pair.Value;
            book.DisplayBookDetails();
            string status = book.IsClassic() ? "Classic Book" : "Modern Book";
            Console.WriteLine($"Status: {status}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(book.GetGenreMessage());
        }
    }
    public void DisplayBookDetails()
    {
        if (Author == null)
            return;
        Console.WriteLine($"details of the book: {Id} {Title} { Author} {YearPublished} {Price}");
    }

    public bool IsClassic()
    {
      return  YearPublished <=1990;
    }

    public string GetGenreMessage() => Genre switch
    {
        GenreType.Fiction => "Immerse in a world of imagination.",
        GenreType.NonFiction => "Based on real events and facts.",
        GenreType.Science => "Explore the universe of science.",
        GenreType.Biography => "Life stories of remarkable people.",
        GenreType.History => "Learn from the past.",
        _ => "Unknown genre."
    };
}