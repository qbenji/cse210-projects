using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _activityName;
    private string _activityDesc;
    private int _duration;
    DateTime startTime;
    DateTime endTime;

    public Activity(string activityName, string activityDesc)
    {
        _activityName = activityName;
        _activityDesc = activityDesc;
        _duration = 10;
    }

    public Activity(string activityName, string activityDesc, int duration)
    {
        _activityName = activityName;
        _activityDesc = activityDesc;
        _duration = duration;
    }

    public void DisplayStart()
    {
        Console.WriteLine($"Welcome to the {_activityName}!\n\n{_activityDesc}\n\nHow long, in seconds, would you like for your session? ");
        int answer = int.Parse(Console.ReadLine());
        SetDuration(answer);
        Console.WriteLine($"\nGet ready! \n");
        Spinner(5);
    }

    public void DisplayEnd()
    {
        Console.WriteLine($"Well done!!\n\nYou completed the {_activityName} in {_duration} seconds!");
    }

    public void Spinner(int seconds)
    {
        List<string> spinner = new List<string>() {"|", "/", "-", "\\", "|"};
        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void DotBuffer(int seconds)
    {
        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }   
        Console.WriteLine("Done!");
    }
 
    public void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {   
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void SetName(string activityName)                // set activity name
    {
        _activityName = activityName;
    }
 
    public void SetActivityDescription(string activityDesc) // set description
    {
        _activityDesc = activityDesc;
    }

    public void SetDuration(int duration)                   // set duration in seconds
    {
        _duration = duration;
    }
   
   public string GetName()                                  // activity name
    {
        return _activityName;
    }

    public string GetActivityDescription()                  // activity description
    {
        return _activityDesc;
    }
    
    public int GetDuration()                                // duration in seconds
    {
        return _duration;
    }

}