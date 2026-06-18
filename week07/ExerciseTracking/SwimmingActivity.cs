// *************************************************************
// Author: Martins Chinedu Amorin
// Course: CSE 210
// Assignment: Week 07 Exercise Tracking Program.
// *************************************************************

using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    // This will create a swimming activity.
    public SwimmingActivity(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // This will calculate the swimming distance.
    public override double GetDistance()
    {
        return (_laps * 50 / 1000.0) * 0.62;
    }

    // This will calculate the swimming speed.
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // This will calculate the swimming pace.
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}