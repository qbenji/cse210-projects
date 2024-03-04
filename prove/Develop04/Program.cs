using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        Console.Write("Welcome to the Mindfulness Program. Press enter to begin");
        Console.ReadLine();
        
        while (choice != 4)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.Write("\n  1. Breathing Activity\n  2. Reflection Activity\n  3. Listing Activity\n  4. Quit\n> ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Breathing Activity
                    BreathingActivity bActivity = new BreathingActivity
                    ("Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    30);
                    bActivity.DisplayStart();
                    bActivity.Breathing();
                    bActivity.DisplayEnd();
                    break;

                case 2: // Reflection Activity
                    ReflectingActivity rActivity = new ReflectingActivity
                    ("Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    30);
                    rActivity.DisplayStart();
                    rActivity.Prompt();
                    rActivity.Question();
                    rActivity.DisplayEnd();
                    break;

                case 3: // Listing Activity
                    ListingActivity lActivity = new ListingActivity
                    ("Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    30);
                    lActivity.DisplayStart();
                    lActivity.List();
                    lActivity.DisplayEnd();
                    break;

                case 4: // Quit
                    Console.Clear();
                    Console.WriteLine("You are now exiting the program. Goodbye.");
                    break;

                default: // invalid choice
                    Console.WriteLine("\nInvalid Choice, try again.");
                    break;
            }
        }
    }
}