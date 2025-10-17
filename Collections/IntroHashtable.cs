using System.Collections;

namespace Collections
{
    public class IntroHashtable
    {
        public static void Main(String[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(11137, "srinivas");
            hashtable.Add(11138, "koushik"); 
            hashtable.Add(11139, "keeratana");
            hashtable.Add(111310, "chinna");
            hashtable.Add(111311, "sagar");
        
            // get the values of student using id's
            Console.WriteLine(hashtable[11137]);
            // Asking user for an ID to search
            Console.Write("Enter Student ID to search: ");
            int searchId;
        
            if (int.TryParse(Console.ReadLine(), out searchId))
            {
                // Check if the ID exists
                if (hashtable.ContainsKey(searchId))
                {
                    Console.WriteLine($"Student Found: {hashtable[searchId]}");
                }
                else
                {
                    Console.WriteLine("Student ID not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a numeric ID.");
            }
        }
        
    } 
}

