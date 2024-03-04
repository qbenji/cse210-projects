public class ReflectingPromptGenerator
{
    public string[] _prompts = new string[]         // array of prompts
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public string[] _questions = new string[]       // array of questions
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public string GetRandomPrompt()                 // get random prompt
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

    public string GetRandomQuestion()               // get random question
    {
        Random random = new Random();
        int index = random.Next(_questions.Length);
        return _questions[index];
    }
}