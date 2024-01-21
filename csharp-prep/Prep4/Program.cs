using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEnter a list of integers (positive or negative), type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
    
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        Console.WriteLine($"\nSum: {numbers.Sum()}\nAverage: {numbers.Average()}\nMaximum: {numbers.Max()}");

        // Stretch
        numbers.Sort();
        int leastPositive = 999999999;

        Console.WriteLine("\nSorted List: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            if (leastPositive > num & num >= 0)
            {
                leastPositive = num;
            }
        }
        Console.WriteLine($"\nLeast Positive: {leastPositive}");
        
        /* 👇 Alternate code to meet core 👇
        int numCount = 0;
        int sum = 0;
        int max = -999999999;
        int avg = 0;

        foreach (int num in numbers)
        {
            numCount += 1;
            sum += number;
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine($"Sum: {sum}\nAverage: {sum/numCount}\nMaximum: {max}");
        // ---------------------------------------------------------------------------
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
        //*/
    }
}