// *************************************************************
// Author: Martins Chinedu Amorin
// Course: CSE 210
// Assignment: Week 07 Exercise Tracking Program
// *************************************************************

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This will create a collection of activities.
        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 Nov 2022", 30, 3.0));
        activities.Add(new CyclingActivity("04 Nov 2022", 45, 15.0));
        activities.Add(new SwimmingActivity("05 Nov 2022", 40, 40));

        // This will display summaries using polymorphism.
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}