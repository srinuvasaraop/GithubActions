namespace Tasks;

public class Task16AA
{
    private readonly List<Task16A> _tasks = [];

    public void AddExpenses(string Title, int Rating, string? ReviewText)
    {
        if (Rating==0 || Rating > 10)
            throw new ArgumentOutOfRangeException("Rating is out of range");
        _tasks.Add(new Task16A(Title, Rating, ReviewText));
    }

    static void Main(string[] args)
    {
        Task16AA aa = new Task16AA();

        var reviewsToAdd = new List<(string Title, int Rating, string? ReviewText)>
        {
            ("Inception", 9, "Mind-blowing sci-fi thriller"),
            ("Titanic", 8, "Epic romance and disaster movie"),
            ("The Room", 0, "So bad it's good"),
            ("The Boss", 15, "Lets walk through the room'"),
            ("Cats", 2, null)
        };

        foreach (var (title, rating, reviewText) in reviewsToAdd)
        {
            try
            {
                aa.AddExpenses(title, rating, reviewText);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error adding review '{title}': {e.Message}");
            }
        }

        aa.GetReview();
        aa.GetBestReview();
    }
    private void GetReview()
    {
        foreach (var review in _tasks)
            Console.WriteLine($"Title: {review.Title} Rating:{review.Rating} ReviewText: {review.ReviewText ?? "No review provided"}");
    }
    private void GetBestReview()
    {
        var highRatedReviews = _tasks.Where(r => r.Rating >= 8);
        foreach (var review in highRatedReviews)
        {
            Console.WriteLine($"best reviews: {review.Title}, Rating: {review.Rating}, Review: {review.ReviewText ?? "No review provided"}");
        }
    }
}