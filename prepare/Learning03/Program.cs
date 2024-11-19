using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fractions using different constructors
        Fraction fraction1 = new Fraction(); // Default 1/1
        Fraction fraction2 = new Fraction(5); // 5/1
        Fraction fraction3 = new Fraction(3, 4); // 3/4
        Fraction fraction4 = new Fraction(1, 3); // 1/3

        // Display fractions and their decimal values
        Console.WriteLine("Testing Fraction Class:");
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");

        // Modify and display using setters and getters
        fraction1.SetTop(2);
        fraction1.SetBottom(5);
        Console.WriteLine("\nAfter modifying Fraction 1:");
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
    }
    }
