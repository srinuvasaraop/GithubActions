using System.Collections;

namespace Collections;

public class IntroHashtable3
{
    static void Main()
    {
        // Creating a Hashtable to store Employee ID and Name
        Hashtable employees = new Hashtable();

        // Adding employees using Add() method
        employees.Add(101, "Alice");
        employees.Add(102, "Bob");
        employees.Add(103, "Charlie");
        employees.Add(104, "David");

        while (true)
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Search Employee");
            Console.WriteLine("3. Remove Employee");
            Console.WriteLine("4. Display All Employees");
            Console.WriteLine("5. Clear All Records");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

        }
    }
}