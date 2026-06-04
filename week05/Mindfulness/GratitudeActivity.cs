// Gratitude Activity
// Extra activity added to exceed assignment requirements.

using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity()
    {
        _name = "Gratitude Activity";

        _description =
            "This activity helps you focus on things you are grateful for.";
    }

    // Runs the gratitude activity
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Think about three things you are grateful for today.");
        Console.WriteLine();

        ShowSpinner(_duration);

        DisplayEndingMessage();
    }
}