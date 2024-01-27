using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();

        Square _square = new Square("White", 4);
        // Console.WriteLine($"{_square.GetArea()}");
        Rectangle _rectangle = new Rectangle("Red", 4, 6);
        // Console.WriteLine($"{_rectangle.GetArea()}");
        Circle _circle = new Circle("Blue", 4);
        // Console.WriteLine($"{_circle.GetArea()}");
        _shapes.Add(_square);
        _shapes.Add(_rectangle);
        _shapes.Add(_circle);

        foreach (Shape shape in _shapes) {
            Console.WriteLine($"{shape.GetColor()}");
            Console.WriteLine($"{shape.GetArea()}");
        }

    }
}