using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // This is to generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            // Keep looping until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();

                guess = int.Parse(userInput);

                // Count the guesses
                guessCount++;

                // Check the guess
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display number of guesses
            Console.WriteLine($"You made {guessCount} guesses.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();

            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}