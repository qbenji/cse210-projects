using System;

public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string eventType, string rsvpEmail)
        : base(title, description, date, time, address, eventType)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string FullDetails()
    {
        return $"{GetEventType()} - {GetTitle()}\n{GetDescription()}\n\n  {GetAddress()}\n   {GetDate()} @ {GetTime()}\n\nRSVP Email: {_rsvpEmail}";
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
}