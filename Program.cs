// program.cs
// Version 2 - Calculates Maximum Heart Rate of a Person

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Maximum Heart Rate Calculator (Version 2) ===");

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age) && age > 0)
        {
            int maxHeartRate = 220 - age;
            Console.WriteLine($"Your estimated Maximum Heart Rate is: {maxHeartRate} bpm.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number for age.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
