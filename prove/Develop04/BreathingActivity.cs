public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDesc, int duration) 
        : base(activityName, activityDesc, duration) 
    {}

    public void BreathIn(int seconds)       // breath in function
    {
        Console.WriteLine("Breathe in...");
        Timer(seconds);
    }

    public void BreathOut(int seconds)      // breath out function
    {
        Console.WriteLine("Breath Out...");
        Timer(seconds);
    }
    
}