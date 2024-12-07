public class GratitudeActivity : Activity
{
    public GratitudeActivity() : base("Gratitude Journal Activity",
        "This activity will help you focus on the positives by listing things you are grateful for.")
    { }

    public override void PerformActivity()
    {
        DisplayStartMessage();
        Console.WriteLine("Start listing things you're grateful for (press Enter after each one):");
        int itemCount = 0;
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
            {
                itemCount++;
            }
        }

        Console.WriteLine($"You listed {itemCount} things you're grateful for!");
        DisplayEndMessage();
    }
}
