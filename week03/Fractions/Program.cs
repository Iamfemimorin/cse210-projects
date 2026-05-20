using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // Added protection against zero denominator.
        // Added automatic fraction simplification.
        // Added cleaner output formatting.

        Console.WriteLine("=== FRACTION PROGRAM ===");
        Console.WriteLine();

        // First constructor
        Fraction f1 = new Fraction();

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine();

        // Second constructor
        Fraction f2 = new Fraction(5);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine();

        // Third constructor
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine();

        // Another fraction
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        Console.WriteLine();

        // Testing setters and getters
        Fraction f5 = new Fraction();

        f5.SetTop(8);
        f5.SetBottom(12);

        Console.WriteLine("Before Simplifying:");
        Console.WriteLine(f5.GetFractionString());

        // Creativity feature
        f5.Simplify();

        Console.WriteLine("After Simplifying:");
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        Console.WriteLine();

        // Intelligent creativity test
        Fraction f6 = new Fraction(7, 0);

        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());
    }
}