// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Shapes
        Shape square = new Square("Red", 4);
        Shape rectangle = new Rectangle("Blue", 5, 3);
        Shape circle = new Circle("Green", 2.5);

        // Add shapes to a list
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Display properties and areas
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea():F2}\n");
        }
    }
}
