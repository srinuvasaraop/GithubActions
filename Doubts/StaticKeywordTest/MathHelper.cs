namespace Doubts.StaticKeywordTest;

public static class MathHelper
{
    static void Main(string[] args)
    {
        Console.WriteLine(MathHelper.GetCubeNumber(10));
    }
    public static int GetCubeNumber(int number)
    {
        return number * number*number;
    }
}