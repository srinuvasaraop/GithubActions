namespace Tasks;

public class Task15AAA
{
   
    static void Main(string[] args)
    {
        Task15AA task15Aaa = new Task15AA();
        List<Task15A>  expensesToAdd= new ()
        {
            new Task15A{Id=456,Amount = 0,Description = "Babai!", Date = DateTime.Now},
            new Task15A{Id=123,Amount = 1,Description = "Hello World!", Date = DateTime.Now},
            new Task15A{Id=789,Amount = 9,Description = "what's up!", Date = DateTime.Now}
        };
        foreach (var expense in expensesToAdd)
        {
            try
            {
                task15Aaa.AddExpense(expense);
                Console.WriteLine("Expense added successfully!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid argument: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finished processing expense with Id: " + expense.Id);
            }
        }
        Console.WriteLine(task15Aaa.GetTotal());
    }
}