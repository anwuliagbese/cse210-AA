public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _completionTarget;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int completionTarget, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _completionTarget = completionTarget;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _completionTarget)
        {
            _timesCompleted = 0; // Reset for next cycle
            return Points + _bonusPoints;
        }
        return Points;
    }

    public override string Display()
    {
        return $"Completed {_timesCompleted}/{_completionTarget} times - {Name} - {Description} (Points: {Points})";
    }

    public override string ToString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_timesCompleted}|{_completionTarget}|{_bonusPoints}";
    }

    public static ChecklistGoal FromString(string data)
    {
        var parts = data.Split('|');
        return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]))
        {
            _timesCompleted = int.Parse(parts[4])
        };
    }
}
