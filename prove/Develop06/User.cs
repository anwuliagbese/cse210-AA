public class User
{
    public string Name { get; private set; }
    public int Score { get; private set; }
    private List<Goal> Goals;

    public User(string name)
    {
        Name = name;
        Score = 0;
        Goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        var goal = Goals.FirstOrDefault(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            int pointsEarned = goal.RecordEvent();
            UpdateScore(pointsEarned);
            Console.WriteLine($"You earned {pointsEarned} points! Total score: {Score}");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private void UpdateScore(int points)
    {
        Score += points;
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        foreach (var goal in Goals)
        {
            Console.WriteLine(goal.Display());
        }
        Console.WriteLine($"\nTotal Score: {Score}");
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(Name);
            writer.WriteLine(Score);
            foreach (var goal in Goals)
            {
                writer.WriteLine(goal.GetType().Name + "|" + goal.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                Name = reader.ReadLine();
                Score = int.Parse(reader.ReadLine());
                Goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string data = parts[1];

                    if (type == "SimpleGoal")
                        Goals.Add(SimpleGoal.FromString(data));
                    else if (type == "EternalGoal")
                        Goals.Add(EternalGoal.FromString(data));
                    else if (type == "ChecklistGoal")
                        Goals.Add(ChecklistGoal.FromString(data));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
