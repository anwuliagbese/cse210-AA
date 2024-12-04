public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { }

    public override void PerformActivity()
    {
        DisplayStartMessage();
        int duration = GetDuration();
        while (duration > 0)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(4);
            duration -= 4;
            if (duration <= 0) break;

            Console.WriteLine("Breathe out...");
            ShowSpinner(4);
            duration -= 4;
        }
        DisplayEndMessage();
    }
}
