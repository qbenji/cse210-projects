using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Assignment A = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(A.GetSummary());
        Console.WriteLine("");

        MathAssignment mA = new MathAssignment("Roberto Carlos", "Fractions", "7.3", "8-19");
        Console.WriteLine(mA.GetSummary());
        Console.WriteLine(mA.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment wA = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wA.GetSummary());
        Console.WriteLine(wA.GetWritingInformation());
        Console.WriteLine("");
    }
}