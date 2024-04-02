using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;
    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()                        // get title
    {
        return _title;
    }

    public string GetDescription()                  // get description
    {
        return _description;
    }

    public DateTime GetDate()                       // get date
    {
        return _date;
    }

    public TimeSpan GetTime()                       // get time
    {
        return _time;
    }

    public Address GetAddress()                     // get address
    {
        return _address;
    }

    public void SetTitle(string title)              // set title
    {
        _title = title;
    }

    public void SetDescription(string description)  // set description
    {
        _description = description;
    }

    public void SetDate(DateTime date)               // set date
    {
        _date = date;
    }

    public void SetTime(TimeSpan time)               // set time
    {
        _time = time;
    }

    public void SetAddress(Address address)          // set address
    {
        _address = address;
    }

}