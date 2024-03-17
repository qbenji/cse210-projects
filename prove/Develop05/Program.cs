using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int choice = 0;
        int points = 0;
        Console.Write("Welcome to the Goal-Points Tracker. Press enter to begin");
        Console.ReadLine();
        List<String> goals = new List<string>();
        List<String> serializedGoals = new List<string>();
        
        while (choice != 4)
        {   
            Console.Clear();
            Console.WriteLine($"You have {points} points.\n");
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
                        case 1:         // Create Simple Goal
                            SimpleGoal sGoal = new SimpleGoal("Simple Goal", "This is a simple goal.",0,false);
                            sGoal.CreateGoal();
                            goals.Add(sGoal.RepresentGoal());
                            serializedGoals.Add(sGoal.SerializeGoal());
                            break;

                        case 2:         // Create Eternal Goal
                            EternalGoal eGoal = new EternalGoal("Simple Goal", "This is a simple goal.",0,false);
                            eGoal.CreateGoal();
                            goals.Add(eGoal.RepresentGoal());
                            serializedGoals.Add(eGoal.SerializeGoal());
                            break;

                        case 3:         // Create Checklist Goal
                            ChecklistGoal cGoal = new ChecklistGoal("Simple Goal", "This is a simple goal.",0,false,0,0,0);
                            cGoal.CreateGoal();
                            goals.Add(cGoal.RepresentGoal());      
                            serializedGoals.Add(cGoal.SerializeGoal());             
                            break;

                        default:        // Invalid Choice
                    
                            break;
                    }

                    break;

                case 2: // List Goals
                    int i = 0;
                    foreach (String goal in goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {goal}");
                    }
                    break;

                case 3: // Save Goals
                    string filename = "myFile.txt";

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(points);
                        foreach (String goal in serializedGoals)
                        {
                            outputFile.WriteLine(goal);
                        }
                    }
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