using System.ComponentModel.Design;

namespace Tasks;

/*Write a C# program that:
Asks the user for their age.
    Checks if they're eligible to:
Drive (16 or older)
Vote (18 or older)
Rent a car (25 or older)
Display a message about what they are eligible for based on their age.*/

public class Task4
{
    public static void Main()
    {
        int age;
        Console.WriteLine("Hey how old are you?");
        string data=Console.ReadLine();

        if (Int32.TryParse(data, out age)) 
        {
            switch (age)
            {
              case >= 16 and < 18:  
                  Console.WriteLine("I am 16 years old, maybe You can drive but not vote yet");
                  break;
              case >=18 and < 24:
                  Console.WriteLine("I am 18 years old");
                  break;
              case 24:
                  Console.WriteLine("I am 24 years old");
                  break;
            }
        }
        else
        {
            Console.WriteLine("Your age is not a valida one ");
        }
        
        
    }
}