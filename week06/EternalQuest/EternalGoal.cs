/*
 * EternalGoal.cs
 * ----------------------------------
 * Represents a goal that never ends.
 *
 * Example:
 * Read scriptures every day.
 *
 * Users receive points every time
 * they record progress.
 */

using System;

public class EternalGoal : Goal
{
    // Creates a new Eternal Goal.
    public EternalGoal(string name,
                       string description,
                       int points)
        : base(name, description, points)
    {
    }

    // Awards points every time.
    public override int RecordEvent()
    {
        return _points;
    }

    // Eternal goals are never complete.
    public override bool IsComplete()
    {
        return false;
    }

    // Returns goal details.
    public override string GetDetailsString()
    {
        return $"[∞] {_shortName} ({_description})";
    }

    // Returns save string.
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}