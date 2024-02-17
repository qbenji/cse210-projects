using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _ref = new Reference();
        Scripture _scrip = new Scripture();
        Console.Write($"{_ref.GetReference()} ");
        _scrip.GetScripture();
    }   
}