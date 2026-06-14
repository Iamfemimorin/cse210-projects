/*
 * SimpleGoal.cs
 * ----------------------------------
 * Represents a goal that can only
 * be completed one time.
 *
 * Example:
 * Run a Marathon
 */

using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Creates a new Simple Goal.
    public SimpleGoal(string name,
                      string description,
                      int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Used when loading saved goals.
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    /*
     * Records completion of the goal.
     * Awards points once.
     */
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    // Returns completion status.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Returns goal information for display.
    public override string GetDetailsString()
    {
        string check = _isComplete ? "[X]" : "[ ]";

        return $"{check} {_shortName} ({_description})";
    }

    // Returns formatted save string.
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}