using System;
using System.Runtime.CompilerServices;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string eventType, string speaker, int capacity) 
        : base(title, description, date, time, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{GetEventType()} - {GetTitle()}\n{GetDescription()}\n\n  {GetAddress().SerializeAddress()}\n   {GetDate()} @ {GetTime()}\n\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetSpeaker()                  // get speaker
    {
        return _speaker;
    }

    public int GetCapacity()                    // get capacity
    {
        return _capacity;
    }

    public void SetSpeaker(string speaker)      // set speaker
    {
        _speaker = speaker;
    }

    public void SetCapacity(int capacity)       // set capacity
    {
        _capacity = capacity;
    }

}