using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        int choice = 1;

        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        while (choice != 2)
        {
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



        
        /* int index = 0;
        string scripture = _scrip.GetScripture();
        string reference = _ref.GetReference();
        string[] words = _scrip.GetScripture().Split(" ");

        Console.WriteLine(scripture);
        Console.WriteLine(reference);

        Console.WriteLine("\nPress enter to continue or type 'quit' to exit: ");
        choice = Console.ReadLine();

        while (choice != "quit")
        {
            foreach (string word in words)
            {
                Word w = new Word(word);
                w.HideWord();
                words[index] = w.GetWord();
                Console.Write($"{words[index]} ");
                index += 1;
                for (int i = 0; i < words.Length; i++)
                {
                    
                }
                
            }
        }
        */
    }   
}