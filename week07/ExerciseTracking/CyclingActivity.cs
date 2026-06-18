// *************************************************************
// Author: Martins Chinedu Amorin
// Course: CSE 210
// Assignment: Week 07 Exercise Tracking Program
// *************************************************************

using System;

public class CyclingActivity : Activity
{
    private double _speed;

    // This will create a cycling activity.
    public CyclingActivity(string date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // This will calculate the cycling distance.
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // This will return the cycling speed.
    public override double GetSpeed()
    {
        return _speed;
    }

    // This will calculate the cycling pace.
    public override double GetPace()
    {
        return 60 / _speed;
    }
}