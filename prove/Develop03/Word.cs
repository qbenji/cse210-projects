using System;
using System.Collections.Generic;

public class Word
{
    private string _word;
    private string _backupWord;
    private List<char> _letters = new List<char>();
    private bool _hidden = false;
    
    public Word(string word)
    {
        _word = word;
        _backupWord = word;
        foreach (char letter in _word)
        {
            _letters.Add(letter);
        }
    }

    public void Hide()
    {
        _hidden = true;
        for (int i = 0; i < _letters.Count; i++)
        {
            _letters[i] = '_';
        }
        _word = new string(_letters.ToArray());
    }

    public void Show()
    {
        _hidden = false;
        _word = _backupWord;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetRenderedText()
    {
        return _word;
    }

}
