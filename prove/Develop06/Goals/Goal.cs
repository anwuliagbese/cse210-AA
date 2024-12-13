public abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent(); // Abstract method to record an event
    public abstract string Display(); // Abstract method to display the goal status

    // Override ToString() to avoid hiding the inherited ToString() method
    public override string ToString()
    {
        return $"{GetType().Name}|{Name}|{Description}|{Points}";
    }
}
