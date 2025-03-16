using System;

public class Job
{
    // Member variables to store job details
    public string _jobTitle;  // The title of the job (e.g., Software Engineer)
    public string _company;   // The company where the job was held (e.g., Microsoft)
    public int _startYear;    // The year the job started (e.g., 2019)
    public int _endYear;      // The year the job ended (e.g., 2022)

    // Method to display job details in the format: Job Title (Company) StartYear-EndYear
    public void Display()
    {
        // Print the job details using string interpolation
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
