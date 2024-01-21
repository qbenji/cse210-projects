using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        int numCount = 0;
        int sum = 0;
        int max = -999999999;
        int avg = 0;
        while (number != 0)
        {
            numCount += 1;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
            sum += number;
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine($"Sum: {sum}\nAverage: {sum/numCount}\nMaximum: {max}");

        /*
        👇 Just to demonstrate I know how to use "for" loops to do the same thing I did in the while loop 👇

        */
    }
}