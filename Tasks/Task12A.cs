namespace Tasks;

public class Task12A
{
    private string City{set; get;}
    private WeatherCondition Condition{set; get;}
    private double TemperatureCelsius{set; get;}
    private int Humidity{set; get;}
    private string? AlertMessage{set; get;}

    public void DisplayWeatherReport()
    {
        Console.WriteLine($"\n--- Weather Report for {City} ---");
        Console.WriteLine($"Condition: {Condition}");
        Console.WriteLine($"Temperature: {TemperatureCelsius}°C");
        Console.WriteLine($"Humidity: {Humidity}%");

        // Alert message (if any)
        if (!string.IsNullOrWhiteSpace(AlertMessage))
        {
            Console.WriteLine($"*** ALERT: {AlertMessage} ***");
        }

        // Optional: Switch expression (C# 8.0)
        string message = Condition switch
        {
            WeatherCondition.Sunny => "It's a bright and sunny day!",
            WeatherCondition.Cloudy => "Expect some clouds today.",
            WeatherCondition.Rainy => "Don't forget your umbrella.",
            WeatherCondition.Stormy => "Stay indoors! Storm warning.",
            WeatherCondition.Snowy => "Wrap up warm, it's snowing.",
            _ => "Weather data is unclear."
        };

        Console.WriteLine($"Note: {message}");
    }

    static void Main(string[] args)
    {
        Dictionary<string, Task12A> cityWeather = new()
        {
            ["Hyderabad"] = new Task12A
            {
                City = "Hyderabad",
                Condition = WeatherCondition.Sunny,
                TemperatureCelsius = 34.5,
                Humidity = 40
            },
            ["Delhi"] = new Task12A
            {
                City = "Delhi",
                Condition = WeatherCondition.Cloudy,
                TemperatureCelsius = 30.0,
                Humidity = 60
            },
            ["Shimla"] = new Task12A
            {
                City = "Shimla",
                Condition = WeatherCondition.Snowy,
                TemperatureCelsius = -2,
                Humidity = 90,
                AlertMessage = "Heavy snowfall warning!"
            }
        };
        foreach (var city in cityWeather)
        {
            city.Value.DisplayWeatherReport();
        }
        /*Console.Write("\nEnter a city name: ");
        string? inputCity = Console.ReadLine();

        if (inputCity != null && cityWeather.TryGetValue(inputCity, out var Foundcity))
        {
            Foundcity.DisplayWeatherReport();
        }
        else
        {
            Console.WriteLine("City not found!");
        }*/
        
    }
}