using System;

class Program
{
    static void Main(string[] args)
    {
        // Activities
        Activity running = new Running(DateTime.Now, 30, 1.5);
        Activity cycling = new Cycling(DateTime.Now, 30, 15);
        Activity swimming = new Swimming(DateTime.Now, 30, 3);

        // Listify
        Activity[] activities = { running, cycling, swimming };

        // Summary
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}