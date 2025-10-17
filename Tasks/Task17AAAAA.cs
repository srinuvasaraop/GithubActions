namespace Tasks;

public class Task17AAAAA
{
    static void Main(string[] args)
    {
        /*List<Task17A> tasks = new ()
        {
            new Task17AA { Name = "Dog" },
            new Task17AAA{ Name = "Cat" },
            new Task17AAA{ Name = "Bird" },
        };*/
        
        List<Task17A> tasks = 
        [
            new Task17AA { Name = "Dog" },
            new Task17AAA{ Name = "Cat" },
            new Task17AAAA{ Name = "Bird" },
        ];
        
        foreach (var task in tasks)
        {
            Console.WriteLine();
            Console.WriteLine(task.Name);
            task.MakeSound();
            Console.WriteLine(task.GetInfo());
            string message = task switch
            {
               Task17AA => $"{task.Name} is loyal and friendly",
               Task17AAA => $"{task.Name} is independent",
               Task17AAAA => $"{task.Name} can fly",
               _ => $"{task.Name} is an unknown animal."
            };
            Console.WriteLine(message);
            
        }

    }
}