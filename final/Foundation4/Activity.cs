using System;

public class Activity
{
    private DateTime _date;
    private int _durationMin;

    public Activity(DateTime date, int durationMin) // constructor
    {
        _date = date;
        _durationMin = durationMin;
    }

    public virtual double GetDistance()             // get distance
    {
        return 0;
    }

    public virtual double GetSpeed()                // get speed
    {
        return 0;
    }

    public virtual double GetPace()                 // get pace
    {
        return 0;
    }

    public virtual string GetSummary()              // get summary
    {
        return $"{_date:dd MMM yyyy} ({GetType().Name} {_durationMin} min): " +
               $"Distance {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }

    public DateTime GetDate()                       // get date
    {
        return _date;
    }

    public int GetDurationMin()                     // get durationMin
    {
        return _durationMin;
    }

    public void SetDate(DateTime date)              // set date
    {
        _date = date;
    }

    public void SetDurationMin(int durationMin)     // set durationMin
    {
        _durationMin = durationMin;
    }

}