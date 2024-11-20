using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(2, "green"));
        shapes.Add(new Rectangle(2, 3, "blue"));
        shapes.Add(new Circle(1, "purple"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetArea()} {shape.GetColor()}");
        }
    }
}