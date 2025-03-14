using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

      
    
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // Initialize the letter grade variable
        string letter = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the user passed or failed
        if (grade >= 70)
        {
            Console.WriteLine($"Your grade is {letter}. Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}. Keep working hard, you'll get it next time!");
        }

        // Stretch challenge: Determine the sign (+ or -)
        string sign = "";

        if (letter != "F")
        {
            int lastDigit = grade % 10;  // Get the last digit of the grade
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Print the final grade with the sign
        if (letter == "F")
        {
            Console.WriteLine($"Your grade is {letter}.");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}{sign}.");
        }
    }
}