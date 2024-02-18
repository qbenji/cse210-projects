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
        _scripture = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _scriptureWords = _scripture.Split(" ");
        for (int i = 0; i < _scriptureWords.Length; i++)
        {
            _scriptureWordsTracker.Add(false);
        }        
    }

    public Scripture(string scripture)
    {
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
            } while (_scriptureWordsTracker[iRandom] == true && _allHidden == false);
            Word w = new Word(_scriptureWords[iRandom]);
            w.Hide();
            _scriptureWordsTracker[iRandom] = true;
            _scriptureWords[iRandom] = w.GetRenderedText();
        }
        _scripture = String.Join(" ", _scriptureWords);
    }

    public string Display()
    {
        return $"{_reference.GetReference()}\n{_scripture}";
    }
}