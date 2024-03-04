public class ReflectingActivity : Activity
{
    public ReflectingActivity(string activityName, string activityDesc, int duration)       // constructor
        : base(activityName, activityDesc, duration) 
    {}

    public ReflectingPromptGenerator rPromptGenerator = new ReflectingPromptGenerator();    // pull in reflecting prompt generator

    public void Prompt()                                                                    // initial prompt
    {
        Console.Clear();
        Console.Write($"--- {rPromptGenerator.GetRandomPrompt()} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void Question()                                                                  // final prompt
    {
        Console.WriteLine("Ponder on each of the following questions as they relate to the prompt.\n\nYou may begin in: ");
        Timer(5);
        Console.Clear();
        int duration = GetDuration()/2;
        Console.WriteLine($"> {rPromptGenerator.GetRandomQuestion()}");
        Spinner(duration);
        Console.WriteLine($"> {rPromptGenerator.GetRandomQuestion()}");
        Spinner(duration);
    }
}