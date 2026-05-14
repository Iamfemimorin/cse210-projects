using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _name = "";

    public List<Job> _jobs = new List<Job>();

    // Method to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and display it
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}