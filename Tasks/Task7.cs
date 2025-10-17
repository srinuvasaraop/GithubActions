namespace Tasks;

public class Task7
{
     int[] numbers = { 10, 20, 30, 40, 50 };
     private int  sized= 0;
     static void Main(string[] args)
    {
        Task7 data = new Task7();
        data.Forloopexp();
        data.whileloop();

    }
    void Forloopexp()
    {
        for (int i = 0; i<numbers.Length; i++)
        {
            Console.WriteLine($"For loop"+numbers[i]);
        }
    }
    void whileloop()
    {
        while (sized < numbers.Length)
        {
            Console.WriteLine($"For loop"+numbers[sized]);
            sized++;
        }
    }
    void foreachloopexp()
    {
        foreach (var VARIABLE in numbers)
        {
            Console.WriteLine($"For loop"+numbers[VARIABLE]);
        }    
    }
}
