namespace Doubts;

public class PropertiesTest
{
    PropertiesTest(string he,int sf)
    {
        Name = he;Price = sf;
    }
    public string Name
    { get; set; }

    public decimal Price
    { get;set; }

    static void Main(string[] args)
    {
        PropertiesTest test = new PropertiesTest("Hello World",1250);
        Console.WriteLine($"Hello World{test.Name} {test.Price}");
    }
}