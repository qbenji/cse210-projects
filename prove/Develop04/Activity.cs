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

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }

    public void Spinner()
    {
        List<string> spinner = new List<string>() {"|", "/", "-", "\\", "|"};
        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void Timer()
    {
        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }   
        Console.WriteLine("Done!");
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