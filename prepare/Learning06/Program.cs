using System;

class Program
{
    static void Main(string[] args)
    {
         // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add shapes to the list
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Iterate through the list and display color and area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}