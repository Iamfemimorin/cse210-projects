using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // This is to create a list to store numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        // Keep asking for numbers until the user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            userNumber = int.Parse(input);

            // This is to not add 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // This is to calculate the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        // This is to calculate the average
        double average = (double)sum / numbers.Count;

        // This is to find the largest number
        int largestNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        // This is to find the smallest positive number
        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // This is to sort the list
        numbers.Sort();

        // For results display
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

        // This is to display the smallest positive number
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // This is to display the sorted list
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}