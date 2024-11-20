using System;

class Program
{
    static void Main(string[] args)
    {

       // Initialize the library with multiple scriptures
        Library library = new Library();

        Reference ref1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture1 = new Scripture(ref1, text1);
        library.AddScripture(scripture1);

        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        string text2 = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture2 = new Scripture(ref2, text2);
        library.AddScripture(scripture2);

        while (true)
        {
            Scripture scripture = library.GetRandomScripture();
            if (scripture == null)
            {
                Console.WriteLine("No scriptures available.");
                break;
            }

            while (true)
            {
                scripture.Display();
                Console.WriteLine("Press Enter to hide a few words or type 'quit' to exit to main menu.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    scripture.HideRandomWord();
                    if (scripture.AllWordsHidden())
                    {
                        scripture.Display();
                        Console.WriteLine("All words are hidden. Returning to main menu.");
                        break;
                    }
                }
            }

            Console.WriteLine("Do you want to select another scripture? (yes/no)");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "yes")
            {
                break;
            }
        }

        Console.WriteLine("Thank you for using the Scripture Memorization Program!");
    }
}
