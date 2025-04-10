using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

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
