using System;
using System.Collections.Generic;

public class MindfulnessApp
{
    private static readonly Dictionary<int, Activity> Activities = new Dictionary<int, Activity>
    {
        {1, new BreathingActivity()},
        {2, new ReflectionActivity()},
        {3, new ListingActivity()}
    };

    public static void DisplayMenu()
    {
        Console.WriteLine("Choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
    }

    public static void Run()
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();
            if (choice == "4")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            else if (Activities.ContainsKey(int.Parse(choice)))
            {
                Activities[int.Parse(choice)].StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
