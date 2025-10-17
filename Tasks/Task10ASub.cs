    namespace Tasks;
    /// <summary>
    /// Task10ASub means Car
    /// </summary>
    public class Task10ASub
    {
        //public int CardID;
        //public string Make;
        //public string Model;
        //public double Price;
        //public Task10A Owner;
        public static int TotalCars { get; private set; }
        public int CardID { get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Task10A Owner { get; set; }
        
       public  Task10ASub(int cardID, string make, string model, double price, Task10A owner)
        {
            CardID = cardID;
            Make = make;
            Model = model;
            Price = price;
            Owner = owner;
            TotalCars++;
        }
        static void Main(string[] args)
        {
           var task = new Task10ASub(1445,"Innova", "Land crusier",150000, new Task10A(11123,"Srinivasp","Hyderabad"));
           var task2 = new Task10ASub(1235,"BYE", "XUV700",178000, new Task10A(1323,"sivaknathv","goa"));
           List<Task10ASub> carList = new List<Task10ASub>{ task, task2 };
            Task10ASub.DisplayTotalCars();
            foreach (var cardetails in carList)
            {
                Console.WriteLine(cardetails);
            }
            
        }
        public override string ToString()
        {
            return $"Boss i am executing with TOstring method:\n{Owner.City}\n{Owner.OwnerID}\n{Owner.Name}\n{Make}\n{Model}\n{Price:C}\n{CardID}\n";
        }
        public static void DisplayTotalCars()
        {
            Console.WriteLine($"{TotalCars} cars");
        }
    }