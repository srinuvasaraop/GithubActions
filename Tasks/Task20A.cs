namespace Tasks;

public class Task20A
{
    public required string Name{set; get;}
    public required string PhoneNumber{set; get;}
    public required string Email{set; get;}
    public string? Address;
    public DateTime? Birthday;

    public void DisplayInfo()
    {
        Console.WriteLine($""" Contact {PhoneNumber}""");
    }
}