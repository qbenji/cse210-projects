using System;

public class Scripture
{
    private string _scripture;
    private string[] _scriptureWords;
    public Scripture()
    {
        _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
    }

    public Scripture(string scripture)
    {
        _scripture = scripture;
    }

    public void GetScripture()
    {
        _scriptureWords = _scripture.Split(" ");
        
        foreach (string word in _scriptureWords)
        {
            Console.Write($"{word} ");
        }
    }
}