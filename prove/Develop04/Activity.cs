public class Activity
{
    protected string _activityName;
    protected string _activityDesc;
    protected int _duration;

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

    }

    public void DisplayEnd()
    {

    }

    public void Spinner()
    {
        
    }

    public void Timer()
    {

    }
}