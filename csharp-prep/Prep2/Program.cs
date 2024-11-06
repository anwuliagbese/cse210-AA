using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Keep trying, you’ll do better next time!");
        }

        // Stretch Challenge: Determine the "+" or "-" sign
        string sign = "";
        int lastDigit = gradePercentage % 10;

        if (letter != "A" && letter != "F")  // No A+ and no F+ or F-
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-"; // A- is valid
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
