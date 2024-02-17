public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseNum;
    private string _endVerseNum;
    public Reference()
    {
        _book = "Proverbs";
        _chapter = "3";
        _verseNum = "5";
        _endVerseNum = "6";
    }
    public Reference(string book, string chapter, string verseNum)
    {
        _book = book;
        _chapter = chapter;
        _verseNum = verseNum;
    }
    public Reference(string book, string chapter, string verseNum, string endVerseNum)
    {
        _book = book;
        _chapter = chapter;
        _verseNum = verseNum;
        _endVerseNum = endVerseNum;
    }

    public string GetReference()
    {
        if (_endVerseNum == null)
        {
            return $"{_book} {_chapter}:{_verseNum}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseNum}-{_endVerseNum}";
        }
    }
}