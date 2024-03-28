using System;

public class Comment
{
    private string _name;
    private string _comment;
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetComment()              // get comment
    {
        return _comment;
    }

    public string GetName()                 // get name
    {
        return _name;
    }

    public void SetComment(string comment)  // set comment
    {
        _comment = comment;
    }

    public void SetName(string name)        //  set name
    {
        _name = name;
    }

}