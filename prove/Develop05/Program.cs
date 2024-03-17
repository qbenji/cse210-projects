using System;
using System.IO;
using System.Reflection.Metadata;

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
        Console.Clear();
        
        while (choice != 6)
        {   
            Console.WriteLine($"\nYou have {points} points.\n");
            Console.WriteLine("Menu Options:");
            Console.Write("\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\n> ");
            choice = int.Parse(Console.ReadLine());
            int choice2;

            switch (choice)
            {
                case 1: // Create New Goal
                    
                    Console.Clear();
                    Console.Write("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n\nWhich type of goal would you like to create? > ");
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
                    
                    Console.Clear();
                    int i = 0;
                    foreach (String goal in goals)
                    {
                        i++;
                        Console.WriteLine($"{i}. {goal}");
                    }
                    break;

                case 3: // Save Goals
                    Console.Clear();
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
                    
                    Console.Clear();
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

                        switch (goalType)
                        {
                            case "SimpleGoal":
                                string[] details00 = goalDetails.Split(',');
                                bool isCompleted = bool.Parse(details00[3]);
                                SimpleGoal sGoal = new SimpleGoal(goalName, goalDesc, goalPoints, isCompleted);
                                goals.Add(sGoal.RepresentGoal());
                                serializedGoals.Add(sGoal.SerializeGoal());                                
                                break;

                            case "EternalGoal":
                                EternalGoal eGoal = new EternalGoal(goalName, goalDesc, goalPoints, false);
                                goals.Add(eGoal.RepresentGoal());
                                serializedGoals.Add(eGoal.SerializeGoal());
                                break;
                            
                            case "ChecklistGoal":
                                string[] details0 = goalDetails.Split(',');
                                bool isCompleted0 = bool.Parse(details0[3]);
                                int bonusPoints = int.Parse(details0[4]);
                                int countToBonus = int.Parse(details0[5]);
                                int currentCount = int.Parse(details0[6]);                            
                                ChecklistGoal cGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, isCompleted0, bonusPoints, countToBonus, currentCount);
                                goals.Add(cGoal.RepresentGoal());
                                serializedGoals.Add(cGoal.SerializeGoal());
                                break;

                            default:
                                break;
                        }
                    }               
                    break;

                case 5: // Record Event
                    
                    Console.Clear();
                    int i2 = 0;
                    foreach (String goal in goals)
                    {
                        i2++;
                        Console.WriteLine($"{i2}. {goal}");
                    }                    

                    Console.Write("Which goal did you accomplish? ");
                    int targetGoal = int.Parse(Console.ReadLine());

                    string serializedGoal = serializedGoals[targetGoal-1];
                    string[] parts2 = serializedGoal.Split(':');
                    string goalType2 = parts2[0];
                    string goalDetails2 = parts2[1];

                    switch (goalType2)
                    {
                        case "SimpleGoal":
                            string[] details2 = goalDetails2.Split(',');                      
                            SimpleGoal sGoal = new SimpleGoal(details2[0], details2[1], int.Parse(details2[2]), true);
                            goals[targetGoal-1] = sGoal.RepresentGoal();
                            serializedGoals[targetGoal-1] = sGoal.SerializeGoal();
                            points+=sGoal.GetGoalPoints();                           
                            break;

                        case "EternalGoal":
                            string[] details3 = goalDetails2.Split(',');                     
                            EternalGoal eGoal = new EternalGoal(details3[0], details3[1], int.Parse(details3[2]), false);
                            goals[targetGoal-1] = eGoal.RepresentGoal();
                            serializedGoals[targetGoal-1] = eGoal.SerializeGoal();
                            points+=eGoal.GetGoalPoints();
                            break;
                        
                        case "ChecklistGoal":
                            string[] details4 = goalDetails2.Split(',');
                            bool isCompleted2 = bool.Parse(details4[3]);
                            int bonusPoints2 = int.Parse(details4[4]);
                            int countToBonus2 = int.Parse(details4[5]);
                            int currentCount2 = int.Parse(details4[6]);
                            Console.Write("How many times did you accomplish it? ");
                            currentCount2 += int.Parse(Console.ReadLine());

                            if (currentCount2>=countToBonus2)
                            {
                                points+=bonusPoints2;
                                isCompleted2 = true;
                            }

                            ChecklistGoal cGoal = new ChecklistGoal(details4[0], details4[1], int.Parse(details4[2]), isCompleted2, bonusPoints2, countToBonus2, currentCount2);
                            goals[targetGoal-1] = cGoal.RepresentGoal();
                            serializedGoals[targetGoal-1] = cGoal.SerializeGoal();
                            break;

                        default:
                            break;           
                    }
                    break;

                case 6: // Quit
                    Console.Clear();
                    Console.WriteLine("\nYou are now exiting the program. Goodbye.");
                    break;

                default: // Invalid Choice                    
                    break;
            }
        }
    }
}