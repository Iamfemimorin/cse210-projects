using System;

class Program
{
    static void Main(string[] args) 
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        // Input converted to an integer
        int grade = int.Parse(userInput);

        // Variables for letter and sign
        string letter = "";
        string sign = "";

        // To determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // To determine the sign (+ or -)
        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // This is to handle special cases
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if (letter == "F")
        {
            sign = "";
        }

        // Grade displayed
        Console.WriteLine($"Your grade is {letter}{sign}");

        // To determine pass or fail
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can do better next time.");
        }
    }
}