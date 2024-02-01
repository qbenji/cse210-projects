using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 1;
        
        while (choice != 5)
        {
        Console.WriteLine("Welcome to your Journal.\nPlease select one of the following choices:");
        Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

        choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    // TODO: Save response to file
                    Entry entry = new Entry();
                    entry._prompt = prompt;
                    entry._response = response;
                    entry._entryDate = DateTime.Now;
                    Console.WriteLine(entry._prompt);
                    Console.WriteLine(entry._response);
                    Console.WriteLine(entry._entryDate);

                    // Journal
                    journal._entries.Add(entry);

                    break;
                case 2:
                    foreach (Entry singleEntry in journal._entries)
                    {
                        Console.Write($"{singleEntry._entryDate} {singleEntry._prompt}\n{singleEntry._response}");
                    }
                    Console.WriteLine("Display");
                    break;
                case 3:
                    Console.WriteLine("Load");
                    break;
                case 4:
                    Console.WriteLine("Save");
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