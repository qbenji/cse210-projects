public class ReflectingActivity : Activity
{
    public ReflectingActivity(string activityName, string activityDesc, int duration) 
        : base(activityName, activityDesc, duration) 
    {}

    public ReflectingPromptGenerator rPromptGenerator = new ReflectingPromptGenerator();

    public void InitialPrompt()
    {
        Console.WriteLine($"\n\n--- {rPromptGenerator.GetRandomPrompt()} ---\n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void FinalPrompt()
    {
        Console.WriteLine("\n\nPonder on each of the following questions as they relate to the prompt.\n\nYou may begin in: ");
        Timer(5);
        Console.Clear();
        int duration = GetDuration()/2;
        Console.WriteLine($"> {rPromptGenerator.GetRandomQuestion()}");
        Spinner(duration);
        Console.WriteLine($"> {rPromptGenerator.GetRandomQuestion()}");
        Spinner(duration);
    }
}