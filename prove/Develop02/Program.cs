// Enhancement: JSON support for journal entries storage.
// This allows journal entries to be saved and loaded in JSON format,
// which can make data management and transfer more robust and flexible.
using System;
using System.Collections.Generic;


class Program
{
    static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    static Journal journal = new Journal();

    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    journal.Display();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();
        journal.AddEntry(prompt, response, date);
    }

    static void SaveJournal()
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}