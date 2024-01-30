using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 1;
        while (choice != 5)
        {
        Console.WriteLine("Welcome to your Journal.\nPlease select one of the following choices:");
        Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

        choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Write");
                    break;
                case 2:
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
            }
        }
    }
}