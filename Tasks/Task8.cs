namespace Tasks;

public class Task8
{
    public int Make;
    public string Model;
    public int Year;
    public double Price;
    public static int TotalCars;
    public Task8()
    {
        Console.WriteLine("Hey am default task8");
    }
     public Task8(int Makes, string Names, int Years, double Prices)
    {
        this.Make = Makes;
        this.Model = Names;
        this.Year = Years;
        this.Price = Prices;
        TotalCars += 1;

    }
    
    static void Main(string[] args)
    {
        Task8 task8 = new Task8(1,"Maruti",4,20000);
        task8.DisplayCarDetails();
        Console.WriteLine($"Total cars: {TotalCars}");
        task8.GetCarAge();
        Console.WriteLine($"IS Affordable : {task8.IsAffordable()}");
        Task8 task9 = new Task8(2,"Honda",7,30000);
        task9.DisplayCarDetails();
        Console.WriteLine($"Total cars: {TotalCars}");
        task9.GetCarAge();
        task9.IsAffordable();
        Console.WriteLine($"IS Affordable : {task9.IsAffordable()}");
        Task8 task10 = new Task8(3,"Tata",11,40000);
        task10.DisplayCarDetails();
        Console.WriteLine($"Total cars: {TotalCars}");
        task10.GetCarAge();
        Console.WriteLine($"IS Affordable : {task10.IsAffordable()}");
        task8.Addinglist(); 
    }

   public  void DisplayCarDetails()
    {
        Console.WriteLine($"Make: {Make} \nModel: {Model} \nYear: {Year} \nPrice: {Price}");
    }

    public void GetCarAge()
    {
        switch (Year)
        {
             case <5:
                 Console.WriteLine($"New car: {Year}");
                 break;
             case >5 and <= 10:
                 Console.WriteLine($"Family car: {Year}");  
                 break;
             case > 10:
                 Console.WriteLine($"Old car: {Year}");
                 break;
        }
    }

    public bool IsAffordable()
    {
        return Price <= 20000;
    }

   void Addinglist()
    {
          List<Task8> tasks = new List<Task8>();
          tasks.Add(new Task8(100,"Tata Curve",4,15000));
          tasks.Add(new Task8(200,"XEC92 Punch",4,20000));
          
          Dictionary<int,Task8> dictionary = new Dictionary<int, Task8>();
          dictionary.Add(1, new Task8(1,"Tata Punch",4,20000));
          dictionary.Add(2, new Task8(2, "Honda", 15, 16000));
          Task8 car1 = dictionary[1];
          car1.DisplayCarDetails();
          car1.IsAffordable();
          
          foreach (var VARIABLE in tasks)
          {
               if(VARIABLE.IsAffordable())
                   Console.WriteLine($"It is affordable:{VARIABLE.Model}");
          }
          
    }
}
