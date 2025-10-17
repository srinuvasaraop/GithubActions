namespace Tasks;

public class Task10B
{
    private int ProductID{get;set;}
    private String Name{get;set;}
    private double Price{get;set;}
    private int Quantity{get;set;}

    public Task10B(int productID, string name, double price, int quantity)
    {
        this.ProductID = productID;
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }
    public void DisplayProduct() => 
        Console.WriteLine($"Product details are: {ProductID}, {Name}, {Price}, {Quantity}");

    static void Main(string[] args)
    {
        Task10B unocorn = new Task10B(65816,"Unicorn",1530000,14);
        Task10B N160 = new Task10B(6889,"N160",200000,11);
        Task10B Karizma = new Task10B(1245,"N160",200000,1);
        Dictionary<int,Task10B> products = new Dictionary<int, Task10B>();
        products.Add(65816, unocorn);
        products.Add(6889, Karizma);
        products.Add(1246, N160);
        foreach (var item in products)
        {
            Console.WriteLine($"Key: {item.Key}");
            item.Value.DisplayProduct();
            if (item.Value.Quantity < 5)
                Console.WriteLine("Not enough product please add more products");
                   
        }
        
    }
}