public class ListingPromptGenerator
{
    public string[] _prompts = new string[]     // array of prompts
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()             // get random prompt
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}