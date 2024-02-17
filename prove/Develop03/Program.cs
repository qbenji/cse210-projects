using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _ref = new Reference("Proverbs", "3", "5", "6");
        Console.WriteLine($"{_ref.GetReference()}\n");
    }
}