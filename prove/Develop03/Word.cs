using System;

public class Word
{
    private string _word;
    private List<char> _letters;
    private bool _hidden = false;
    public Word(string word)
    {
        _word = word;
    }

    public void HideWord()
    {
        _hidden = true;
        _letters = Word.ToList();
    }
}