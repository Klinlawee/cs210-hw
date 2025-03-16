using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, this is week02 Resume assignment");
        // Create the first job instance and set its details
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";   // Set the job title
        job1._company = "Microsoft";           // Set the company name
        job1._startYear = 2019;                // Set the start year of the job
        job1._endYear = 2022;                  // Set the end year of the job

        // Create the second job instance and set its details
        Job job2 = new Job();
        job2._jobTitle = "Manager";            // Set the job title
        job2._company = "Apple";              // Set the company name
        job2._startYear = 2022;               // Set the start year of the job
        job2._endYear = 2023;                 // Set the end year of the job

        // Create a resume instance
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";       // Set the person's name for the resume

        // Add the jobs to the resume
        myResume._jobs.Add(job1);             // Add the first job to the job list
        myResume._jobs.Add(job2);             // Add the second job to the job list

        // Display the resume details
        myResume.Display();                   // Call the Display method to show the resume details
    }
}
