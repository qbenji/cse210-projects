using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (Please type only the # part of the percentage & do not convert it to decimal) ");
        string gradeText = Console.ReadLine();
        
        // Key Variables
        int gradeNum = int.Parse(gradeText);
        string gradeLetter;
        string gradeSign;

        // Logic to determine letter
        if (gradeNum >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeNum >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeNum >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeNum >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        // Logic to determine grade sign
        if (gradeNum % 10 >= 7 && gradeNum < 90 && gradeNum > 60)
        {
            gradeSign = "+";
        }
        else if (gradeNum % 10 < 3 && gradeNum > 60)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }

        Console.WriteLine($"\nYour letter grade is: {gradeLetter}{gradeSign}");

        // Logic to determine pass or fail
        if (gradeNum >= 70)
        {
            Console.WriteLine("You have passed your class. Well done!");
            Console.WriteLine("\"The price of success is hard work, dedication to the job at hand, and the determination");
            Console.WriteLine("that whether we win or lose, we have applied the best of ourselves to the task at hand.\" \n~ Vince Lombardi");
        }
        else
        {
            Console.WriteLine("You have failed your class. It may be good to ask yourself: \"What could I have done differently?\"\nDetermining the reason for failure is a vital step in conquering it");
            Console.WriteLine("\n\"Failures are finger posts on the road to achievement.\"\n~ C.S. Lewis");
        }
    }
}