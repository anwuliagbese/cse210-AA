using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                string tags = string.Join(",", entry.Tags);
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}|{entry.Mood}|{tags}|{entry.Location}");

            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                Entry entry = new Entry
            {
                Date = parts[0],
                Prompt = parts[1],
                Response = parts[2],
                Mood = int.Parse(parts[3]),
                Tags = new List<string>(parts[4].Split(',')),
                Location = parts[5]
            };
            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}
}
    
