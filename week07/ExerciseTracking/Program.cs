using System;

namespace FitnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new Activity[]
            {
                new Running(new DateTime(2022, 11, 3), 30, 4.8),
                new Cycling(new DateTime(2022, 11, 3), 45, 20.0),
                new Swimming(new DateTime(2022, 11, 3), 30, 40)
            };

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
// // This is the main entry point of the program. It creates an array of different activities (Running, Cycling, Swimming) and iterates through each activity to print its summary using the GetSummary method. The activities are initialized with specific dates, durations, and parameters relevant to each activity type. The output will display the details of each activity in a formatted string.
// // The program demonstrates polymorphism, as the same method (GetSummary) is called on different types of activities, and each type provides its own implementation of the method to display the relevant information.