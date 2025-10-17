namespace Tasks;

public class Task15AA
{
    //ExpenseTracker
    private List<Task15A> expenses = new List<Task15A>();
    
    public void AddExpense(Task15A firstclass)
    {
            if (firstclass.Amount <=0)
            {
                 throw new NullReferenceException("Something went wrong");
            }
            expenses.Add(firstclass);
       
    }

    public decimal GetTotal()
    {
        decimal total = 0;
        foreach (var expense in expenses)
        {
            total += expense.Amount;
        }
        return total;
    }
}