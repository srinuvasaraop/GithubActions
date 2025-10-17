namespace Tasks;

public class Task15BB
{
    private readonly List<Task15B> expenses = [ ]; // Collection expression (C# 12.0)

    public void AddExpense(string? description, decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero");
        expenses.Add(new Task15B(description, amount, DateTime.Now));
    }

    public void DisplayExpenses()
    {
        foreach (var exp in expenses)
        {
            Console.WriteLine($"Date: {exp.Date}, Amount: {exp.Amount:C}, Description: {exp.Description ?? "No description"}");
        }
    }
}