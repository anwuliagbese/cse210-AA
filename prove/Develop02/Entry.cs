using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public int Mood { get; set; } // Mood rating (1-10)
    public List<string> Tags { get; set; } // Tags (e.g., "work", "family")
    public string Location { get; set; } // User's location

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Tags = new List<string>(); // Initialize the tags list
    }

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood: {Mood}");
        Console.WriteLine($"Tags: {string.Join(", ", Tags)}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine();
    }
}
