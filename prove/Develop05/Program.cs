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
            int choice2;

            switch (choice)
            {
                case 1: // Create New Goal
                    
                    Console.Clear();
                    Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n\nWhich type of goal would you like to create?");
                    choice2 = int.Parse(Console.ReadLine());
                    switch (choice2)
                    {
                        case 1:         // Simple Goal

                            break;

                        case 2:         // Eternal Goal

                            break;

                        case 3:         // Checklist Goal
                           
                            break;

                        default:        // Invalid Choice
                    
                            break;
                    }

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