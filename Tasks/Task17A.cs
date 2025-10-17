namespace Tasks;

public abstract class Task17A
{
    public abstract void MakeSound();
    public string Name { get; set; }

    public virtual string GetInfo()
    {
        return $" This is an animal ";
    }
}