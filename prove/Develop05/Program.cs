using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        int points = 0;
        Console.Write($"You have {points} points.");
        Console.ReadLine();
        
        while (choice != 4)
        {   
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.Write("\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\n> ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Create New Goal
                    
                    break;

                case 2: // List Goals
                    
                    break;

                case 3: // Save Goals
                    
                    break;

                case 4: // Load Goals
                    
                    break;

                case 5: // Record Event
                    
                    break;

                case 6: // Quit
                    
                    break;

                default: // Invalid Choice
                    
                    break;
            }
        }
    }
}