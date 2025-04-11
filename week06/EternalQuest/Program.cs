using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int totalScore = 0;

        while (true)
        {
            try
            {
                Console.WriteLine("Welcome to Eternal Quest!");
                Console.WriteLine("1. Create a new goal");
                Console.WriteLine("2. Record an event");
                Console.WriteLine("3. Display goals");
                Console.WriteLine("4. Display score");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        HandleCreateGoal(goals);
                        break;

                    case "2":
                        HandleRecordEvent(goals, ref totalScore);
                        break;

                    case "3":
                        HandleDisplayGoals(goals);
                        break;

                    case "4":
                        Console.WriteLine($"Total Score: {totalScore}");
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please select a valid menu number.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}. Please try again.");
            }
        }
    }

    static void HandleCreateGoal(List<Goal> goals)
    {
        try
        {
            Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
            string type = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            if (type == "1")
                goals.Add(new SimpleGoal(name, description, points));
            else if (type == "2")
                goals.Add(new EternalGoal(name, description, points));
            else if (type == "3")
            {
                Console.Write("Required Count: ");
                int requiredCount = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
            }
            else
            {
                Console.WriteLine("Invalid goal type selected.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter numbers where required.");
        }
    }

    static void HandleRecordEvent(List<Goal> goals, ref int totalScore)
    {
        try
        {
            Console.WriteLine("Select goal to record:");
            for (int i = 0; i < goals.Count; i++)
                Console.WriteLine($"{i + 1}. {goals[i].GetName()}");

            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex < 0 || goalIndex >= goals.Count)
            {
                Console.WriteLine("Invalid goal selection.");
                return;
            }

            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].GetPoints();

            if (goals[goalIndex] is ChecklistGoal checklist && checklist.GetStatus().Contains("Bonus"))
                totalScore += checklist.GetPoints();
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter a valid goal number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while recording the event: {ex.Message}");
        }
    }

    static void HandleDisplayGoals(List<Goal> goals)
    {
        try
        {
            Console.WriteLine("Goals:");
            foreach (Goal goal in goals)
                Console.WriteLine($"{goal.GetName()}: {goal.GetStatus()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while displaying goals: {ex.Message}");
        }
    }
}
