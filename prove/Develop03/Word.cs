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

    public void HideWord()
    {
        _hidden = true;
        foreach (char letter in _word)
        {
            _letters.Add('_');
        }
        _word = new string(_letters.ToArray());
    }

    public void ShowWord()
    {
        _hidden = false;
        _word = _backupWord;
    }

    public bool HiddenCheck()
    {
        return _hidden;
    }

    public string GetWord()
    {
        return _word;
    }

}
