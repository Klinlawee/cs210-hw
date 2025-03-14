using System;
using System.Collections.Generic;
using System.Linq; // Required for sorting and list operations

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        {
        List<int> numbers = new List<int>(); // List to store user inputs
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to collect numbers from user
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()); // Read input and convert to integer
            
            if (number != 0) // Do not add 0 to the list
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Check if the list contains numbers before performing calculations
        if (numbers.Count > 0)
        {
            // Core Requirements:

            // Calculate the sum of all numbers
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            // Calculate the average of the numbers
            double average = numbers.Average();
            Console.WriteLine($"The average is: {average}");

            // Find the maximum number
            int maxNumber = numbers.Max();
            Console.WriteLine($"The largest number is: {maxNumber}");

            // Stretch Challenges:

            // Find the smallest positive number (closest to zero)
            int? smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty(int.MaxValue).Min();
            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }

            // Sort the numbers in ascending order and display them
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
    }
}