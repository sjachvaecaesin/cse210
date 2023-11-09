using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square test1 = new Square("red", 4);
        shapes.Add(test1);

        Rectangle test2 = new Rectangle("blue", 3, 6);
        shapes.Add(test2);

        Circle test3 = new Circle("green", 8);
        shapes.Add(test3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"color: {shape.GetColor()} | area: {shape.GetArea()}");
        }
    }
}