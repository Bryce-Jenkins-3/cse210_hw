public class Rectangle: Shape
{
    double length;
    double width;

    public Rectangle(double length, double width, string color): base(color)
    {
        this.length = length;
        this.width = width;
    }
    public override double GetArea()
    {
        return length * width;
    }
}