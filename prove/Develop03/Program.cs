using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 1;
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        while (choice != 2)
        {
            Scripture scripture = new Scripture();

            Console.Write("\n 1. Play \n 2. Quit\n> ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    string quit = "";
                    while (quit != "quit")
                    {
                        scripture.Display();
                        Console.WriteLine("\nPress enter to start mastering or type 'quit' to exit: ");
                        quit = Console.ReadLine();
                        scripture.HideWords();
                    }
                    break;
                    
                case 2:
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;

                default:
                    Console.WriteLine("\nInvalid Choice, try again.");
                    break;
            }
        }
    }   
}