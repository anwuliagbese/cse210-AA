public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public ReflectionActivity() : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    { }

    public override void PerformActivity()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        Random random = new Random();

        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowSpinner(3);

        while (duration > 0)
        {
            Console.WriteLine(questions[random.Next(questions.Count)]);
            ShowSpinner(4);
            duration -= 4;
        }
        DisplayEndMessage();
    }
}
