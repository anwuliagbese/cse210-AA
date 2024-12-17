using System;

class Program
{
    static void Main(string[] args)
    {
         // Create instances of each activity
        Running running = new Running(5.0, 30.0);     // 5 km in 30 minutes
        Cycling cycling = new Cycling(20.0, 60.0);    // 20 km in 60 minutes
        Swimming swimming = new Swimming(40, 45.0);   // 40 laps in 45 minutes

        // Add activities to a list
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        // Iterate through the list and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}