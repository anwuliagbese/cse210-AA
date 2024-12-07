public static class ActivityLogger
{
    private static Dictionary<string, int> _activityLog = new Dictionary<string, int>();

    public static void LogActivity(string activityName)
    {
        if (_activityLog.ContainsKey(activityName))
        {
            _activityLog[activityName]++;
        }
        else
        {
            _activityLog[activityName] = 1;
        }
    }

    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        foreach (var entry in _activityLog)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Console.WriteLine();
    }

    public static void SaveLog(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in _activityLog)
            {
                writer.WriteLine($"{entry.Key},{entry.Value}");
            }
        }
    }

    public static void LoadLog(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    _activityLog[parts[0]] = int.Parse(parts[1]);
                }
            }
        }
    }
}
