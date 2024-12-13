public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return Points; // Always reward points for recording an event
    }

    public override string Display()
    {
        return $"{Name} - {Description} (Points: {Points})";
    }

    public override string ToString()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }

    public static EternalGoal FromString(string data)
    {
        var parts = data.Split('|');
        return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
    }
}
