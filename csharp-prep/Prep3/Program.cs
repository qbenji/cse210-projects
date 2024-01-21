using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? (Integers Only) ");
        int magicNum = int.Parse(Console.ReadLine());
        int guessNum = 0;

        do
        {
            Console.Write("\nWhat is your guess? (Integers Only) ");
            guessNum = int.Parse(Console.ReadLine());

            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }     
        } while (guessNum != magicNum);

    }
} 