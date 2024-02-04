using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 1;
        
        Console.WriteLine("Welcome to your Journal.\nPlease select one of the following choices:");
        while (choice != 5)
        {
        Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

        choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.Write($"\n{prompt}\n> ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;

                    // Journal
                    journal._entries.Add(entry);

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
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}