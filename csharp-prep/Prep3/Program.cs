using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Step 1: Set up the magic number and initialize the guess count
            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            int guessCount = 0;
            int guess = -1;

            // Step 2: Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Step 3: Display the total guesses made
            Console.WriteLine($"It took you {guessCount} guesses.");

            // Step 4: Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
