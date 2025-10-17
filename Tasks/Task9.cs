namespace Tasks;

public class Task9 :Task8
{
    List<Task8> tasks = new List<Task8>();

    public Task9()
    {
        Console.WriteLine("Hey am default task9");
    }
    static void Main(string[] args)
    {
        Task9 task890 = new Task9();
        task890.SeedData();
        task890.IsAffordable();
    }
    public void SeedData()
    {
        tasks.Add(new Task8(12,"Skoda",23,13000.00d));
        tasks.Add(new Task8(13,"Mahindra",23,17000.00d));
        tasks.Add(new Task8(14,"Honda",23,15000.00d));
        tasks.Add(new Task8(15, "Tata", 23, 16000.00d));
        tasks.Add(new Task8(16,"Benz",23,12000.00d));
    }
    public void IsAffordable()
    {
            var affordableCars= from car in tasks
                   where car.Price<=16000.00 orderby car.Price ascending select car;
        foreach (var helo in affordableCars)
        {
            helo.DisplayCarDetails();
        }
    }
}