// Enhancement: JSON support for journal entries storage.
// This allows journal entries to be saved and loaded in JSON format,
// which can make data management and transfer more robust and flexible.
using System;

public class Program
{
        static List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();


        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save the Journal");
            Console.WriteLine("4. Load the Journal");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();
                Entry newEntry = new(DateTime.Now.ToString("yyyy-MM-dd"), randomPrompt, response);
                journal.AddEntry(newEntry);

                // Set the date
                newEntry.Date = DateTime.Now.ToString("yyyy-MM-dd");

                // Get a random prompt (example)
                
                newEntry.Prompt = "What was the best part of your day?";
                newEntry.Prompt ="Who was the most interesting person I interacted with today?";
                newEntry.Prompt ="How did I see the hand of the Lord in my life today?";
        newEntry.Prompt ="What was the strongest emotion I felt today?";
        newEntry.Prompt ="If I had one thing I could do over today, what would it be?";

                Console.WriteLine($"Prompt: {newEntry.Prompt}");
                Console.Write("Your Response: ");
                newEntry.Response = Console.ReadLine();

                // Ask for mood
                Console.Write("Rate your mood (1-10): ");
                newEntry.Mood = int.Parse(Console.ReadLine());

                // Ask for tags
                Console.Write("Add tags (comma-separated): ");
                string tagInput = Console.ReadLine();
                newEntry.Tags = new List<string>(tagInput.Split(','));

                // Ask for location
                Console.Write("Enter your location: ");
                newEntry.Location = Console.ReadLine();

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {   
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}

    