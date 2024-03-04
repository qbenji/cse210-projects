public class ListingActivity : Activity
{
    public ListingActivity(string activityName, string activityDesc, int duration)  // constructor
        : base(activityName, activityDesc, duration) 
    {}

    public ListingPromptGenerator lPromptGenerator = new ListingPromptGenerator();  // pull in listing prompt generator
    DateTime startTime;                                                             // initialize start time
    DateTime endTime;                                                               // initialize end time
    
    public void List()                                                              // list function
    {
        Console.WriteLine($"\nList as many responses as you can to the following prompt:\n\n--- {lPromptGenerator.GetRandomPrompt()} ---\nYou may begin in: ");
        Timer(5);
        int duration = GetDuration();
        startTime = DateTime.Now;
        endTime = startTime.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("> ");
            Console.ReadLine();
        }
    }

}