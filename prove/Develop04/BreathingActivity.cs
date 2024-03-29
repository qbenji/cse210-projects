public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDesc, int duration)    // constructor
        : base(activityName, activityDesc, duration) 
    {}

    public void BreathIn(int seconds)       // breath in function
    {
        Console.Write("Breathe In... ");
        Timer(seconds);
    }

    public void BreathOut(int seconds)      // breath out function
    {
        Console.Write("Breath Out... ");
        Timer(seconds);
    }

    public void Breathing()                 // breathing function
    {
        Console.Clear();
        int duration = GetDuration();
        while (duration > 0)
        {
            BreathIn(4);
            Console.Clear();
            BreathOut(6);
            duration -= 10;
            Console.Clear();
            if (duration < 10 && duration >= 7)
            {
                double number = duration/2;
                int durationOne = (int)Math.Ceiling(number);
                int durationTwo = (int)Math.Floor(number);
                BreathIn(durationOne);
                BreathOut(durationTwo);
                duration -= duration;
            }
            else if (duration < 7 && duration > 0)
            {
                Spinner(duration);
                duration -= duration;
            }
        }
    }
}