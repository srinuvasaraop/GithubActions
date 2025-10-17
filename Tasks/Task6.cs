using System.Diagnostics;

namespace Tasks;

/*Create an enum named WeatherType with at least 5 weather conditions.
    Example: Sunny, Rainy, Cloudy, Snowy, Windy, etc.
    Create a method named GetWeatherMessage that:
    Takes a WeatherType as a parameter.
    Returns a string message based on the weather type.
    Uses a switch statement to handle different cases.
    Create an array of 7 WeatherType values, each representing a day of the week.
    Loop through the array (you can use a for, foreach, or both) and:
Print the day number (e.g., “Day 1”, “Day 2”, etc.).
Call GetWeatherMessage with the current day’s weather and print the result.*/

public enum WeatherType
{
Sunny,
Rainy, 
Cloudy, 
Snowy, 
Windy
}

public class Task6
{
    public WeatherType[] WeeklyWeather = new WeatherType[7]
    {
        WeatherType.Sunny, //sunday
        WeatherType.Rainy, //monday
        WeatherType.Cloudy, //tuesday
        WeatherType.Snowy, //Wednesday
        WeatherType.Windy, //thursday
        WeatherType.Snowy, //Friday
        WeatherType.Windy, //Saturday

    };
    
    static void Main(string[] args)
    {
        Task6 task6 = new Task6();
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Day:{i+1}:{task6.WeeklyWeather[i]}");
            string data=GetWeatherMessage(task6.WeeklyWeather[i]);
            Console.WriteLine(data);
        } 
        string GetWeatherMessage(WeatherType WetherType)
        {
            switch (WetherType)
            {
                case WeatherType.Sunny:
                    return "It's sunny and perfect for a picnic!";
                   
                case WeatherType.Rainy:
                    return "Rain is falling—don't forget your umbrella!";
                   
                case WeatherType.Cloudy:
                    return "it's Cloudy";
                    
                case WeatherType.Snowy:
                    return "it's Snowy";
                    
                case WeatherType.Windy:
                    return "it's Windy";
                default:
                    return "Hey you are not belongs to this wether!";
            }
        }

    }
}