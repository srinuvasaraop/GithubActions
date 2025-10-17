namespace Tasks;

/*Create an array of 5 integers (your choice of values).
    Loop through the array using:
A for loop
A while loop
A foreach loop
In each loop, print each number with a message like:
"Current number is: X"*/
    
public class Task5
{
    int[] number = {1111,22222,33333,4444,55555};
    
    public static void Main(string[] args)
    {
        Task5 task5 = new Task5();
        task5.forloopexp();
        task5.whileloop();
        task5.foreachloopexp();
    }
    void forloopexp()
    {
        int size=number.Length;
        for (int i = 0; i < size; i++)
        { 
          Console.WriteLine($"Hey am for loop {number[i]}");
        }
    }

    void whileloop()
    {
        int flag = 0;
        int size=number.Length;
        while(flag < size)
        {
            Console.WriteLine($"Hey am while loop {number[flag]}");
            flag = flag + 1;
        }
    }
    
    void foreachloopexp()
    {
        foreach (var VARIABLE in number)
        {
           Console.WriteLine($"Hey am foreach loop {VARIABLE}"); 
        }
    }
}