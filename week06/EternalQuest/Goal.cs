/*
 * Goal.cs
 * ----------------------------------
 * Base class for all goals in the Eternal Quest Program.
 *
 * Responsibilities:
 * - Store common goal information.
 * - Define methods that all goal types must implement.
 * - Demonstrate inheritance and polymorphism.
 */

using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    /*
     * Constructor
     * Creates a new goal with a name,
     * description and point value.
     */
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Returns the goal name.
    public string GetName()
    {
        return _shortName;
    }

    // Returns the goal point value.
    public int GetPoints()
    {
        return _points;
    }

    /*
     * Records progress toward a goal.
     * Must be implemented differently
     * by each goal type.
     */
    public abstract int RecordEvent();

    // Determines if goal is complete.
    public abstract bool IsComplete();

    // Returns goal details for display.
    public abstract string GetDetailsString();

    // Returns goal data for saving to file.
    public abstract string GetStringRepresentation();
}