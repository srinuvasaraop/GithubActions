namespace Doubts.StaticKeywordTest;
public class Validator
{
    public bool IsValidName(string name)
    {
        // Call the local static function
        return IsAlphaOnly(name);
        // Static local function to check if all chars are alphabetic
        static bool IsAlphaOnly(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
        }
    }

    public static void Main(string[] args)
    {
        Validator  validator = new Validator();
        Console.WriteLine(validator.IsValidName("svas"));
    }
}