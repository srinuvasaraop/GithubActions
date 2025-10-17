namespace Tasks;

public class Task15BBB
{
    public static void Main()
    {
        var tracker = new Task15BB();

        try
        {
            tracker.AddExpense("Lunch", 12.5m);
            tracker.AddExpense(null, 50m);
            tracker.AddExpense("Office Supplies", -5m); // Will throw exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error adding expense: {ex.Message}");
        }
        tracker.DisplayExpenses();
    }
}