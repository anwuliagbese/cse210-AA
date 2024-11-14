using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        _entries.Add(new Entry(prompt, response, date));
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
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
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
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    _entries.Add(new Entry(prompt, response, date));
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
