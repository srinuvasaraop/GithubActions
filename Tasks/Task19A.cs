namespace Tasks;

public class Task19A
{
    private int OrderId;
    private string CustomerName;
    private List<string> Items;
    private double Amount;

    private static string orderTemplate = """
                           {
                               "OrderId": 101,
                               "CustomerName": "Alice",
                               "Items": ["Laptop", "Mouse"],
                               "TotalAmount": 85000
                           }
                           """;

    Task19A(int orderId, string customerName, List<string> items, double amount)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Items = items;
        Amount = amount;
    }

    public void DisplaySummary()
    {
        if (Items.Count == 2)
        {
            Console.WriteLine($"Order {OrderId}: Combo order detected!");
        }
        else if (Items.Any(item => item.Contains("Phone")))
        {
            Console.WriteLine($"Order {OrderId}: Contains phone-related items.");
        }
        else
        {
            Console.WriteLine($"Order {OrderId}: Standard order processed.");
        }
    }

    static void Main(string[] args)
    {
        List<Task19A> orders =
        [
            new Task19A(104, "Diana", ["sfsd", "Charger", "Phone"], 56000),
            new Task19A(101, "Alice", ["Laptop", "Mouse"], 85000),
            new Task19A(102, "Bob", ["Keyboard", "Monitor"], 32000),
            new Task19A(103, "Charlie", ["Headphones"], 5000),
            
        ];
        Console.WriteLine(orderTemplate);
        foreach (var order in orders)
        {
            order.DisplaySummary();
        }
    }
}