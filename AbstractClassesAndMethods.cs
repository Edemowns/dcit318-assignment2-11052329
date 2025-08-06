using System;

abstract class Shape
{
    public abstract double GetArea();
}


class Circle : Shape
{
    public double Radius { get; set;}
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea(){
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape 
{
    public double Width {get; set; }
    public double Length {get; set; }
    
    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public override double GetArea()
    {
        return Width * Length;
    }
}

class ShapeDemo
{
    static void Main()
    {
        Console.WriteLine("Abstract Classes and Methods");
        Circle myCircle = new Circle(7);
        Rectangle myRectangle = new Rectangle(12, 15);

        Console.WriteLine($"Circle area: {myCircle.GetArea():F2}");
        Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");

    }
}