namespace Tasks;
using static Tasks.Task13A;

public class Task13B
{
    static void Main(string[] args)
    {
        List<Task13A> books = new()
        {
            new Task13A { Id = 1, Title = "Crime", Author = "Srinivas", Price = 10, YearPublished = 2025, Genre = GenreType.Fiction },
            new Task13A { Id = 2, Title = "Non-crime", Author = "Sivakanth", Price = 20, YearPublished = 2026, Genre = GenreType.NonFiction },
            new Task13A { Id = 3, Title = "Science", Author = "Satyendra", Price = 30, YearPublished = 2027, Genre = GenreType.Science },
            new Task13A { Id = 4, Title = "Historical", Author = "Mahesh", Price = 40, YearPublished = 1990, Genre = GenreType.History },
            new Task13A { Id = 5, Title = "Biological", Author = "Satyanandam", Price = 50, YearPublished = 2029, Genre = GenreType.Biography },
            new Task13A { Id = 6, Title = "Cosmos", Author = "Carl Sagan", Price = 60, YearPublished = 1980, Genre = GenreType.Science },
        };
        Dictionary<int, Task13A> bookDict = books.ToDictionary(b => b.Id);
        string searchTitle = "science";
        var foundBook = books.FirstOrDefault(b => b.Title.ToLower() == searchTitle.ToLower());
        Console.WriteLine($"\n🔍 Search by Title '{searchTitle}':");
        if (foundBook != null) foundBook.DisplayBookDetails();
        else Console.WriteLine("Book not found.");

        // 🔍 Search by ID
        int searchId = 3;
        Console.WriteLine($"\n🔍 Search by ID {searchId}:");
        if (bookDict.TryGetValue(searchId, out var bookById)) bookById.DisplayBookDetails();
        else Console.WriteLine("Book ID not found.");

        // 📌 Filter classics
        Console.WriteLine("\n📚 Classic Books:");
        var classics = books.Where(b => b.IsClassic());
        foreach (var book in classics) book.DisplayBookDetails();

        // 📌 Filter by Genre
        GenreType filterGenre = GenreType.Science;
        Console.WriteLine($"\n📘 Books in Genre: {filterGenre}");
        var genreBooks = books.Where(b => b.Genre == filterGenre);
        foreach (var book in genreBooks) book.DisplayBookDetails();

        // 📊 Group by Genre
        Console.WriteLine("\n📊 Books Grouped by Genre:");
        var grouped = books.GroupBy(b => b.Genre);
        foreach (var group in grouped)
        {
            Console.WriteLine($"Genre: {group.Key} ({group.Count()} books)");
            foreach (var book in group)
            {
                Console.WriteLine($" - {book.Title} by {book.Author}");
            }
        }
    }
    
}