public class Program
{
    static void Main(string[] args)
    {
        const string logFilePath = "activityLog.txt";
        ActivityLogger.LoadLog(logFilePath);

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. View Activity Log");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new GratitudeActivity(),
                "5" => null, // Log viewing handled separately
                "6" => null,
                _ => null
            };

            if (choice == "5")
            {
                ActivityLogger.DisplayLog();
                continue;
            }

            if (activity == null) break;

            activity.PerformActivity();
            ActivityLogger.LogActivity(activity.GetType().Name);
        }

        ActivityLogger.SaveLog(logFilePath);
    }
}
