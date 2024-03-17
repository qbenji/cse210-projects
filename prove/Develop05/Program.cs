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
                    Console.WriteLine("Enter the desired filename (.txt will be added automatically): ");
                    string saveFileName = Console.ReadLine();
                    saveFileName = $"{saveFileName}.txt";

                    using (StreamWriter outputFile = new StreamWriter(saveFileName))
                    {
                        outputFile.WriteLine(points);
                        foreach (String goal in serializedGoals)
                        {
                            outputFile.WriteLine(goal);
                        }
                    }
                    break;

                case 4: // Load Goals
                    goals.Clear();
                    serializedGoals.Clear();

                    Console.WriteLine("Enter the filename you wish to load (.txt will be added automatically): ");
                    string loadFileName = Console.ReadLine();
                    loadFileName = $"{loadFileName}.txt";     

                    string[] lines = System.IO.File.ReadAllLines(loadFileName);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(':');
                        string goalType = parts[0];
                        string goalDetails = parts[1];

                        string[] details = goalDetails.Split(',');
                        string goalName = details[0];
                        string goalDesc = details[1];
                        int goalPoints = int.Parse(details[2]);
                        bool isCompleted = bool.Parse(details[3]);
                        int bonusPoints = int.Parse(details[4]);
                        int countToBonus = int.Parse(details[5]);
                        int currentCount = int.Parse(details[6]);

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                SimpleGoal sGoal = new SimpleGoal(goalName, goalDesc, goalPoints, isCompleted);
                                goals.Add(sGoal.RepresentGoal());
                                serializedGoals.Add(sGoal.SerializeGoal());                                
                                break;

                            case "EternalGoal":
                                EternalGoal eGoal = new EternalGoal(goalName, goalDesc, goalPoints, isCompleted);
                                goals.Add(eGoal.RepresentGoal());
                                serializedGoals.Add(eGoal.SerializeGoal());
                                break;
                            
                            case "ChecklistGoal":
                                ChecklistGoal cGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, isCompleted, bonusPoints, countToBonus, currentCount);
                                goals.Add(cGoal.RepresentGoal());
                                serializedGoals.Add(cGoal.SerializeGoal());
                                break;

                            default:
                                break;
                        }
                    }               
                    break;

                case 5: // Record Event
                    
                    break;

                case 6: // Quit
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;

                default: // Invalid Choice                    
                    break;
            }
        }
    }
}