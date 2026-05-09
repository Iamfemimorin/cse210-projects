using System;

class Program
{
    static void Main(string[] args)
    {
        // This is to call the welcome function
        DisplayWelcome();

        // This is to get the user's name
        string userName = PromptUserName();

        // This is to get the user's favorite number
        int favoriteNumber = PromptUserNumber();

        // This is to square the number
        int squaredNumber = SquareNumber(favoriteNumber);

        // This is to display the result
        DisplayResult(userName, squaredNumber);
    }

    // This is the function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // This is the function to ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    // This is the function to ask for and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        return number;
    }

    // This is the function to square a number
    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    // This is the function to display the final result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}