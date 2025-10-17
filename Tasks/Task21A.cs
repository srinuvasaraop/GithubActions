namespace Tasks;

public class Task21A(string Destination, int Days, double Budget)
{
    public void DisplaySummary()
    {
        Console.WriteLine($"Your traveling to {Destination}, total  days {Days}, of budget {Budget}");
    }
    static void Main(string[] args)
    {
        List<Task21A> plans = [new("Paris", 5, 1200), new("Tokyo", 7, 2000)];
        
    }
    static void ShowTrip(ref readonly Task21A TravelPlan)
    {
      TravelPlan.DisplaySummary();
    }
}