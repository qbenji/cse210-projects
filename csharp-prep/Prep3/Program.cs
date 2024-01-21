using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Welcome to Ben's Guessing Game! A random integer will be generated, and it is your task to guess that number in the least amount of tries!");
        Console.Write("Would you like to play? Yes (y) or No (n) ");
        string playing = Console.ReadLine();

        while (playing == "y")
        {   
            int rangeNum = randomGenerator.Next(10, 100);
            int magicNum = randomGenerator.Next(1, rangeNum);
            Console.WriteLine($"Guess a number between 1 & {rangeNum}");
            int guessNum = 0;
            int guessCount = 0;

            do
            {
                Console.Write("\nWhat is your guess? (Integers Only) ");
                guessNum = int.Parse(Console.ReadLine());
                guessCount += 1;

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
                    Console.WriteLine($"You guessed it! It took you {guessCount} tries.");
                }     
            } while (guessNum != magicNum);

            Console.Write("\nWould you like to play again? Yes (y) or No (n) ");
            playing = Console.ReadLine();
        }
        
    }
} 