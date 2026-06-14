/*
 * ChecklistGoal.cs
 * ----------------------------------
 * Represents a goal that must be
 * completed multiple times.
 *
 * Example:
 * Attend the Temple 10 times.
 *
 * Awards points each time and
 * bonus points when completed.
 */

using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Creates a new Checklist Goal.
    public ChecklistGoal(string name,
                         string description,
                         int points,
                         int target,
                         int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    /*
     * Records progress toward the goal.
     * Awards bonus when target reached.
     */
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    // Checks completion status.
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Returns formatted display string.
    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";

        return $"{check} {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";
    }

    // Returns save string.
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}