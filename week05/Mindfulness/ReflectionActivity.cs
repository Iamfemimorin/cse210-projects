using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "What did you learn about yourself?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";

        _description =
            "This activity will help you reflect on times when you have shown strength and resilience.";
    }

    // Runs the reflection activity
    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");

        Console.WriteLine();
        Console.WriteLine("Reflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write($"> {_questions[random.Next(_questions.Count)]} ");

            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}