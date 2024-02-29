using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {   
            Console.WriteLine("Welcome to the Mindfulness Program. Please select one of the following activities to begin a mindfulness session:");
            Console.Write("\n  1. Breathing Activity\n  2. Reflection Activity\n  3. Lising Activity\n  4. Quit\n> ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Breathing Activity
                    break;

                case 2: // Reflection Activity
                    break;

                case 3: // Listing Activity
                    break;

                case 4: // Quit
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;

                default: // invalid choice
                    Console.WriteLine("\nInvalid Choice, try again.");
                    break;
            }
        }
    }
}