using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int math = SquareNumber(num);
        DisplayResult(name,math);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int SquareNumber(int num)
    {
        int math = num * num;
        return math;
    }

    static void DisplayResult(string name, int num)
    {
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
}