using System;

abstract class Activity
{
    private DateTime _date;
    private int _durationMin;

    public Activity(DateTime date, int durationMin)
    {
        _date = date;
        _durationMin = durationMin;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} ({GetType().Name} {_durationMin} min): " +
               $"Distance {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F2} min per km";
    }
}