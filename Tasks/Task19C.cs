namespace Tasks;

public class Task19C
{
    private int OrderId;
    private string CustomerName;
    private List<string> Items;
    private double TotalAmount;
    private string PaymentStatus;

    Task19C(int orderId, string customerName, List<string> items, double totalAmount, string paymentStatus)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Items = items;
        TotalAmount = totalAmount;
        PaymentStatus= paymentStatus;
    }

    public void DisplaySummary()
    {
        if (Items is ["Phone", "Case", ..])
        {
            Console.WriteLine($"Order {OrderId}: Accessory bundle identified");
        }
        else if (Items is [_, _, _, _])
        {
            Console.WriteLine($"Order {OrderId}: Large order detected!");
        }
        else if(PaymentStatus== "Pending")
        {
            Console.WriteLine($"Order {OrderId}: Payment pending – awaiting confirmation.");
        }
        else
        {
            Console.WriteLine($"Order {OrderId}: Regular order processed.");
        }
    }

    static void Main(string[] args)
    {
        List<Task19C> orders =
        [
            new Task19C(101, "Alice", ["Phone", "Case", "Charger"], 1250.50, "Paid"),
            new Task19C(102, "Bob", ["Laptop", "Mouse"], 2100.00, "Pending"),
            new Task19C(103, "Charlie", ["Tablet", "Cover", "Stylus", "Protector"], 1800.75, "Paid"),
            new Task19C(104, "Diana", ["Phone", "Case"], 999.99, "Paid"),
            new Task19C(105, "Ethan", ["Monitor", "Keyboard", "Mouse"], 1450.25, "Pending"),
            new Task19C(106, "Fiona", ["Phone", "Charger", "Earphones", "Case"], 1550.00, "Paid"),
            new Task19C(107, "George", ["Smartwatch", "Band"], 850.00, "Paid"),
            new Task19C(108, "Hannah", ["Laptop", "Bag", "Mouse", "Pad"], 2400.00, "Pending")
        ];
        
        foreach (var order in orders)
        {
            order.DisplaySummary();
        }
    }
}