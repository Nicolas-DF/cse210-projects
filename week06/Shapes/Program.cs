using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        circle.SetColor("Brown");
        Console.WriteLine($"Circle color: {circle.GetCOlor()}");
        Console.WriteLine($"Circle area: {circle.GetArea()}");
        Console.WriteLine();
        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.SetColor("Blue");
        Console.WriteLine($"Rectangle color: {rectangle.GetCOlor()}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        Console.WriteLine();
        Square square = new Square(3);
        square.SetColor("Red");
        Console.WriteLine($"Square color: {square.GetCOlor()}");
        Console.WriteLine($"Square area: {square.GetArea()}");
    }
}