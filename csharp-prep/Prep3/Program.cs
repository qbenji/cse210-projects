using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? (Integers Only) ");
        int magicNum = int.Parse(Console.ReadLine());


        
        Console.Write("What is your guess? (Integers Only) ");
        int guessNum = int.Parse(Console.ReadLine());

        if (guessNum < magicNum)
        {
            Console.Write("Higher");
        }
        else if (guessNum > magicNum)
        {
            Console.Write("Lower");
        }
        else
        {
            Console.Write("You guessed it!");
        } 

    }
} 