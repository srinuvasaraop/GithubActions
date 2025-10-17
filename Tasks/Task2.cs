    namespace Tasks;


    //Create an enum named WeatherType with at least 5 different weather conditions (e.g., Sunny, Rainy, etc.).
    //Write a method that takes a WeatherType as a parameter and returns a message based on the weather, using a switch statement.
    //Call that method with at least 3 different WeatherType values and display the results. */
    public enum WeatherType1
    {
        winter,
        summer,
        rainy,
        autumn,
        sunny
    }
    public class Task2
    {
        static void Main(string[] args)
        {
            
            Task2 myTask = new Task2();
            Console.WriteLine("Static method calls:");
            Console.WriteLine(myTask.GetWeatherMessage(WeatherType1.winter));
            Console.WriteLine(myTask.GetWeatherMessage(WeatherType1.rainy));
            Console.WriteLine(myTask.GetWeatherMessage(WeatherType1.sunny));
            Console.WriteLine();
            
            // 2️⃣ Dynamic user input
           myTask.RunUserInput();
            
        }

        // Method that takes a WeatherType and returns a message
        public string GetWeatherMessage(WeatherType1 weather)
        {
            switch (weather)
            {
                case WeatherType1.winter:
                    return "It's cold and snowy!";
                case WeatherType1.summer:
                    return "It's hot and sunny!";
                case WeatherType1.rainy:
                    return "It's raining—bring an umbrella!";
                case WeatherType1.autumn:
                    return "Leaves are falling!";
                case WeatherType1.sunny:
                    return "Clear skies ahead!";
                default:
                    return "Unknown weather condition.";
            }
        }
        public void RunUserInput()
        
        {
            Console.WriteLine("Please choose one of the following options: winter,summer,autumn,rainy...");
            string season=Console.ReadLine();
            
            if (Enum.TryParse<WeatherType1>(season, ignoreCase: true, out var weather))
            {
                switch (weather)
                {
                    case WeatherType1.winter:
                        Console.WriteLine($"Measured value is winter....");
                        break;

                    case WeatherType1.summer:
                        Console.WriteLine($"Measured value is summer too high.");
                        break;

                    case WeatherType1.autumn:
                        Console.WriteLine("Measured value is atumn too high");
                        break;
                    
                    case WeatherType1.rainy:
                        Console.WriteLine("Measured value is rainy too high F");
                        break;
                }
            }
            else
            {
                // Invalid input — this is your "default" case
                Console.WriteLine("Invalid input. Please enter one of: winter, summer, autumn, rainy.");
            }
        }
    }