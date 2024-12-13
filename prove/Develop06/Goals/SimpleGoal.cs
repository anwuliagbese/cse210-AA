public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return Points;
        }
        return 0; // No points if the goal is already completed
    }

    public override string Display()
    {
        return $"{(_isCompleted ? "[X]" : "[ ]")} {Name} - {Description} (Points: {Points})";
    }

    public override string ToString()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isCompleted}";
    }

    public static SimpleGoal FromString(string data)
    {
        var parts = data.Split('|');
        var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]))
        {
            _isCompleted = bool.Parse(parts[4])
        };
        return goal;
    }
}
