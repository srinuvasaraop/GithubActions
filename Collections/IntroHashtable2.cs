using System.Collections;

namespace Collections;

public class IntroHashtable2
{
    public static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add(11137, "Gandalf");
        hashtable.Add(11138, "NAP");
        hashtable.Add(11139, "Devops");
        hashtable.Add(11140, "Automations");
        hashtable.Add(11141, "FSW");
        String value=Console.ReadLine();
        int ID = int.Parse(value); // Converts string to int
        Console.WriteLine("You entered: " +ID);
        Console.WriteLine("The value id " +hashtable[ID]);
        foreach (var VARIABLE in hashtable)
        {
            Console.WriteLine(VARIABLE);
        }
    } 
}