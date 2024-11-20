using System;

public class Circle: Shape
{
    double radius;

    public Circle(double radius, string color): base(color)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return radius * radius * Math.PI;
    }
}