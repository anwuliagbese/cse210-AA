using System;

public class Swimming : Activity
{
    private int laps;

    // Constructor for Swimming-specific attributes
    public Swimming(int laps, double minutes) : base(minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in min/km
    }

    public override string GetSummary()
    {
        return $"Swimming - {base.GetSummary()}";
    }
}
