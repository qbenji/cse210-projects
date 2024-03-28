using System;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _lenSeconds;
    private List<Comment> _comments;
    public Video (string title, string author, int lenSeconds)  // constructor
    {
        _title = title;
        _author = author;
        _lenSeconds = lenSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)     // add comment
    {
        _comments.Add(comment);
    }

    public int GetNumComments()                 // add comment
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()          // get comments
    {
        return _comments;
    }

    public string GetTitle()                    // get title
    {
        return _title;
    }

    public string GetAuthor()                   // get author
    {
        return _author;
    }

    public int GetLenSeconds()                  // get lenSeconds
    {
        return _lenSeconds;
    }

    public void SetTitle(string title)          // set title
    {
        _title = title;
    }

    public void SetAuthor(string author)        // set author
    {
        _author = author;
    }

    public void SetLenSeconds(int lenSeconds)   // set lenSeconds
    {
        _lenSeconds = lenSeconds;
    }
}