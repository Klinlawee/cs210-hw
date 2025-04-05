// Mindfulness Project
// This program is a simple mindfulness application that allows users to choose from three different activities: Breathing, Reflection, and Listing.
// Each activity has its own class that inherits from a base class called Activity. The program prompts the user to select an activity, sets a duration for it, and guides them through the activity with animations and prompts.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    // Removed the greeting message from the constructor
    public Activity() { }

    public void StartActivity()
    {
        DisplayStartMessage();
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        PrepareUser();
        PerformActivity();
        EndActivity();
    }

    protected abstract void DisplayStartMessage();

    protected void PrepareUser()
    {
        Console.WriteLine("Get ready to begin...");
        AnimatePause(3);
    }

    protected void AnimatePause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".", System.Console.CursorLeft);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();

    protected void EndActivity()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Console.WriteLine($"Total time spent: {duration} seconds.");
        AnimatePause(3);
    }
}

public class BreathingActivity : Activity
{
    protected override void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to your Breathing Activity!");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            AnimatePause(3);
            Console.WriteLine("Breathe out...");
            AnimatePause(3);
        }
    }
}

public class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    protected override void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to your Reflection Activity!");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        AnimatePause(3);

        while (DateTime.Now < endTime)
        {
            string question = Questions[random.Next(Questions.Count)];
            Console.WriteLine(question);
            AnimatePause(5);
        }
    }
}

public class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void DisplayStartMessage()
    {
        Console.WriteLine("Welcome to your Listing Activity!");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    protected override void PerformActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        AnimatePause(3);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        Console.WriteLine("Start listing now:");

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                items.Add(item);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"You listed {items.Count} items!");
        AnimatePause(3);
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        // Ensure the first output when the program is run
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        
        // Run the mindfulness app
        MindfulnessApp.Run();
    }
}
// The program is a simple mindfulness application that allows users to choose from three different activities: Breathing, Reflection, and Listing.
// Each activity has its own class that inherits from a base class called Activity. The program prompts the user to select an activity, sets a duration for it, and guides them through the activity with animations and prompts.