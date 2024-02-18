using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 1;
        string quit;

        while (choice != 3)
        {   
            Scripture scripture = new Scripture();

            Console.WriteLine("Welcome to the Scripture Memorizer!");
            Console.Write("\n 1. Memorize A Scripture \n 2. Memorize User Entered Scripture \n 3. Quit\n> ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: // user memorizes the same scripture
                    Console.WriteLine($"\n{scripture.Display()}");
                    Console.WriteLine("\nPress enter to start mastering or type 'quit' to exit: ");
                    quit = Console.ReadLine();

                    while (quit != "quit" && scripture.IsAllHidden() == false)
                    {   
                        Console.Clear();
                        scripture.HideWords();
                        Console.WriteLine(scripture.Display());
                        Console.WriteLine("\nPress enter to start mastering or type 'quit' to exit: ");
                        quit = Console.ReadLine();
                    }
                    break;

                case 2: // user memorizes their own scripture
                    Console.WriteLine("Enter your own scripture: ");
                    string userScripture = Console.ReadLine();
                    scripture = new Scripture(userScripture);

                    Console.WriteLine($"\n{scripture.Display()}");
                    Console.WriteLine("\nPress enter to start mastering or type 'quit' to exit: ");
                    quit = Console.ReadLine();

                    while (quit != "quit" && scripture.IsAllHidden() == false)
                    {   
                        Console.Clear();
                        scripture.HideWords();
                        Console.WriteLine(scripture.Display());
                        Console.WriteLine("\nPress enter to start mastering or type 'quit' to exit: ");
                        quit = Console.ReadLine();
                    }
                    break;

                case 3: // exits the program
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;

                default: // invalid choice
                    Console.WriteLine("\nInvalid Choice, try again.");
                    break;
            }
        }
    }   
}