namespace Tasks;


public class Task20AA
{
    private List<Task20A> Contacts = new List<Task20A>();

    // Method to add a new contact
    public void AddContact(Task20A contact)
    {
        Contacts.Add(contact);
        Console.WriteLine($"✅ Contact '{contact.Name}' added successfully!");
    }

    // Method to search contacts by name (using LINQ)
    public void SearchContact(string name)
    {
        var results = Contacts
            .Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (results.Count > 0)
        {
            Console.WriteLine($"\n🔍 Found {results.Count} contact(s) matching '{name}':");
            foreach (var contact in results)
            {
                contact.DisplayInfo();
            }
        }
        else
        {
            Console.WriteLine($"\n❌ No contacts found for '{name}'.");
        }
    }

    // Method to display all contacts
    public void DisplayAllContacts()
    {
        switch (Contacts)
        {
            // C# 11.0 list patterns
            case []:
                Console.WriteLine("📭 No contacts available.");
                break;

            case [var single]:
                Console.WriteLine("📇 Only one contact in your book:");
                single.DisplayInfo();
                break;

            default:
                Console.WriteLine($"\n📘 Contact Book ({Contacts.Count} contacts):");
                foreach (var contact in Contacts)
                {
                    contact.DisplayInfo();
                }
                break;
        }
    }
    
    public static void Main()
    {
        Task20AA contactBook = new Task20AA();

        // Adding contacts (required properties enforced)
        contactBook.AddContact(new Task20A
        {
            Name = "Alice",
            PhoneNumber = "1234567890",
            Email = "alice@example.com"
        });

        contactBook.AddContact(new Task20A
        {
            Name = "Bob",
            PhoneNumber = "9876543210",
            Email = "bob@example.com",
            Address = "Main Street"
        });

        // Display all contacts
        contactBook.DisplayAllContacts();

        // Search contact
        contactBook.SearchContact("Alice");
    }
}
