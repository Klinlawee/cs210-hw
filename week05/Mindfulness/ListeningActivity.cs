using System;
using System.Collections.Generic;

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
