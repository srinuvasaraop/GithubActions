namespace Doubts.StaticKeywordTest;

public class TemperatureConverter
{
    static void Main(string[] args)
    {
        Console.WriteLine(TemperatureConverter.CelsiusToFahrenheit(12.5));
    }
    public static double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9.0 / 5 + 32;
    }
}