// *************************************************************
// Author: Martins Chinedu Amorin
// Course: CSE 210
// Assignment: Week 07 Exercise Tracking Program.
// *************************************************************

using System;

public class RunningActivity : Activity
{
    private double _distance;

    // This will create a running activity.
    public RunningActivity(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // This will return the running distance.
    public override double GetDistance()
    {
        return _distance;
    }

    // This will calculate the running speed.
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // This will calculate the running pace.
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}