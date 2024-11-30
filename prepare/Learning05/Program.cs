using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the base Assignment class
        Assignment simpleAssignment = new Assignment("Samuel Elijah", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Robert Alfred", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Adesuwa Utomi", "Nigerian History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}