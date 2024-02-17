using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        Reference _ref = new Reference();
        Scripture _scrip = new Scripture();
        string choice = "";
        int index = 0;
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
            }
        }
    }   
}