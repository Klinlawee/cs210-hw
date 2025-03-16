using System;

public class Resume
{
    public string _name;

    // Initializing the list to a new List before using.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Use of custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}