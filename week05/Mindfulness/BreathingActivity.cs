using System;

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
