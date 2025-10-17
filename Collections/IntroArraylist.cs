namespace Collections;
using System.Collections;
public class IntroArraylist
{
   
    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList(); // here we can pass values as parameter to arraylist() i,e arraylist(10)
        // Here capacity takes as initially Zero 
        Console.WriteLine(list.Capacity);
        list.Add(14534);
        // whenever we add first element the capacity would be 4 automatically
        Console.WriteLine(list.Capacity);
        list.Add(21243);
        list.Add(35464);
        list.Add(2424);
        Console.WriteLine(list.Capacity);
        list.Add(12312);
        //after adding 4 elements the when you add 5 th element the size increased to double meaning that capacity is 8
        Console.WriteLine(list.Capacity);
        
        /*
        // Here we can add elemnents in between,
        // so the previously existed element will move to the next position.
        */
        list.Insert(2,null);
        list.RemoveAt(4);
        foreach (var Final in list)
        {
            Console.WriteLine(Final);
        }
    }   
}