using System;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference = new Reference();
    private Random random = new Random();
    private string _scripture;
    private string[] _scriptureWords;
    private List<bool> _scriptureWordsTracker = new List<bool>();
    private bool _allHidden = false;
    private int iRandom;

    public Scripture()
    {
        _reference = new Reference();
        _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _scriptureWords = _scripture.Split(" ");
        for (int i = 0; i < _scriptureWords.Length; i++)
        {
            _scriptureWordsTracker.Add(false);
        }        
    }

    public Scripture(string scripture)
    {
        string book;
        string chapter;
        string verseNum;
        string endVerseNum;
        string question;

        Console.Write("Enter Book: ");
        book = Console.ReadLine();
        Console.Write("Enter Chapter: ");
        chapter = Console.ReadLine();
        Console.Write("Enter Verse Start Number: ");
        verseNum = Console.ReadLine();
        Console.Write("Is there more than one Verse? (y/n): ");
        question = Console.ReadLine();
    
        if (question == "y")
        {
            Console.Write("Enter Verse End Number: ");
            endVerseNum = Console.ReadLine();
            _reference = new Reference(book, chapter, verseNum, endVerseNum);
        }
        else
        {
           _reference = new Reference(book, chapter, verseNum); 
        }

        _scripture = scripture;
        _scriptureWords = _scripture.Split(" ");
        for (int i = 0; i < _scriptureWords.Length; i++)
        {
            _scriptureWordsTracker.Add(false);
        }        
    }

    public bool IsAllHidden()
    {
        _allHidden = true;
        for (int i = 0; i < _scriptureWordsTracker.Count; i++)
        {
            if (_scriptureWordsTracker[i] == false)
            {
                _allHidden = false;
            }
        }
        return _allHidden;
    }

    public void HideWords()
    {   
        for (int i = 0; i < 3; i++)
        {
            do
            {
                iRandom = random.Next(_scriptureWords.Length);
            } while (_scriptureWordsTracker[iRandom] == true && IsAllHidden() == false);
            if (IsAllHidden() == true)
            {
                break;
            }
            Word w = new Word(_scriptureWords[iRandom]);
            w.Hide();
            _scriptureWordsTracker[iRandom] = w.IsHidden();
            _scriptureWords[iRandom] = w.GetRenderedText();
        }
        _scripture = String.Join(" ", _scriptureWords);
    }

    public string Display()
    {
        return $"{_reference.GetReference()}\n{_scripture}";
    }
}