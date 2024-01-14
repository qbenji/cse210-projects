using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string NameFirst = Console.ReadLine();

        Console.Write("What is your last name? ");
        string NameLast = Console.ReadLine();
        
        Console.WriteLine($"\nYour name is {NameLast}, {NameFirst} {NameLast}.");
    }
}