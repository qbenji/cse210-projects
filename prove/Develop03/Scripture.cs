using System;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference = new Reference();
    private Random random = new Random();
    private string _scripture;
    private string[] _scriptureWords;
    private bool[] _scriptureWordsTracker;
    public Scripture()
    {
        _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _scriptureWords = _scripture.Split(" ");
    }

    public Scripture(string scripture)
    {
        _scripture = scripture;
        _scriptureWords = _scripture.Split(" ");
    }

    public void HideWords()
    {
        for (int i = 0; i < 3; i++)
        {
            int iRandom = random.Next(_scriptureWords.Length);
            Word w = new Word(_scriptureWords[iRandom]);
            w.Hide();
            _scriptureWords[iRandom] = w.GetRenderedText();
        }
        _scripture = String.Join(" ", _scriptureWords);
    }

    public string Display()
    {
        return $"{_reference.GetReference()}\n{_scripture}";
    }
}