using System;

public class Running : Activity
{
    private double distance;

    // Constructor for Running-specific attributes
    public Running(double distance, double minutes) : base(minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Minutes) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return Minutes / distance; // Pace in min/km
    }

    public override string GetSummary()
    {
        return $"Running - {base.GetSummary()}";
    }
}
