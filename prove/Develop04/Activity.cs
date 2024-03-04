using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _activityName;
    private string _activityDesc;
    private int _duration;
    DateTime startTime;
    DateTime endTime;

    public Activity(string activityName, string activityDesc, int duration)
    {
        _activityName = activityName;
        _activityDesc = activityDesc;
        _duration = duration;
    }

    public void DisplayStart()                              // display start message
    {
        Console.Clear();
        Console.Write($"Welcome to the {_activityName}!\n\n{_activityDesc}\n\nHow long, in seconds, would you like for your session? ");
        int answer = int.Parse(Console.ReadLine());
        SetDuration(answer);
        Console.Clear();
        Console.Write($"Get ready! ");
        Spinner(6);
    }

    public void DisplayEnd()                                // display end message
    {
        Console.Clear();
        Console.Write($"Well done!! ");
        Spinner(2); 
        Console.Write($"\nYou completed the {_activityName} in {_duration} seconds!");
        Spinner(5);
    }

    public void Spinner(int seconds)                        // spinner function
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

    public void DotBuffer(int seconds)                      // dot buffer function
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
 
    public void Timer(int seconds)                          // timer function
    {
        for (int i = seconds; i > 0; i--)
        {   
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetActivityName(string activityName)        // set activity name
    {
        _activityName = activityName;
    }
 
    public void SetActivityDescription(string activityDesc) // set description
    {
        _activityDesc = activityDesc;
    }

    public void SetDuration(int duration)                   // set duration
    {
        _duration = duration;
    }
   
   public string GetActivityName()                          // get activity name
    {
        return _activityName;
    }

    public string GetActivityDescription()                  // get activity description
    {
        return _activityDesc;
    }
    
    public int GetDuration()                                // get duration
    {
        return _duration;
    }

}