namespace Tasks;

/// <summary>
/// Create a console application that manages car ownership records.
/// You’ll define two classes: Owner and Car.
/// Each car will be associated with an owner using object composition.
///  Task10A means Owner
/// </summary>
public class Task10A
{
    public int OwnerID;
    public string Name;
    public string City;

    public Task10A(int ownerID, string name, string city)
    {
        OwnerID = ownerID;
        Name = name;
        City = city;
    }
    
}
