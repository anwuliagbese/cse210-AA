public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }

    public override void PerformActivity()
    {
        DisplayStartMessage();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Count)]);
        ShowSpinner(3);

        Console.WriteLine("Start listing items (press Enter after each one):");
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

        Console.WriteLine($"You listed {itemCount} items!");
        DisplayEndMessage();
    }
}
