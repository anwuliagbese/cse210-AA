public abstract class Activity
{
    private string name;
    private string description;
    private int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {name}!");
        Console.WriteLine(description);
        Console.Write("Enter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {name} for {duration} seconds.");
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    public int GetDuration() => duration;
    public abstract void PerformActivity();
}
