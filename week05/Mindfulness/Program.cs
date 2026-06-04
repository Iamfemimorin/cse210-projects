// W05 Mindfulness Program
// Student: Your Name
//
// Creativity Added:
// - Added a fourth activity called Gratitude Activity.
// - This activity encourages users to reflect on things they are grateful for.
// - This exceeds the core requirements by providing an additional mindfulness exercise.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Start Gratitude Activity");
            Console.WriteLine(" 5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    new GratitudeActivity().Run();
                    break;

                case "5":
                    running = false;
                    break;
            }
        }
    }
}