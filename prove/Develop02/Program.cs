using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 1;
        
        Console.WriteLine("Welcome to the Journal Program. If you have a journal already, be sure to load your journal before you begin!\nPlease select one of the following choices:");
        while (choice != 5)
        {
        Console.Write("\n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit\n> ");

        choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;

                case 2:
                    journal.DisplayEntries();
                    break;

                case 3:
                    journal.LoadEntries();
                    break;

                case 4:
                    journal.SaveEntries();
                    break;

                case 5:
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;
                    
                default:
                    Console.WriteLine("\nInvalid Choice, try again.");
                    break;
            }
        }
    }
}