// *************************************************************
// Author: Martins Chinedu Amorin
// Course: CSE 210
// Assignment: Week 07 Exercise Tracking Program
// *************************************************************

using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    // Constructor initializes common activity information.
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // This will return the activity date.
    public string GetDate()
    {
        return _date;
    }

    // This will return the duration of the activity.
    public int GetMinutes()
    {
        return _minutes;
    }

    // This will calculate the activity distance.
    public abstract double GetDistance();

    // This will calculate the activity speed.
    public abstract double GetSpeed();

    // This will calculate the activity pace.
    public abstract double GetPace();

    // This will return a formatted summary of the activity.
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name.Replace("Activity", "")} ({_minutes} min): " +
               $"Distance {GetDistance():F1} miles, " +
               $"Speed {GetSpeed():F1} mph, " +
               $"Pace: {GetPace():F1} min per mile";
    }
}