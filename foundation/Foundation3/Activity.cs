using System;

public abstract class Activity
{
    private double minutes;

    // Constructor for shared attributes
    protected Activity(double minutes)
    {
        this.minutes = minutes;
    }

    // Encapsulation: Public getter for minutes
    public double Minutes
    {
        get { return minutes; }
    }

    // Abstract methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to get a summary of the activity
    public virtual string GetSummary()
    {
        return $"Time: {Minutes} minutes, Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min/km";
    }
}
