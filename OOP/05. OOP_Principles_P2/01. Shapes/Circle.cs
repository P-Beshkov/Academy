using System;

public class Circle : Shape
{
    public Circle(double radius) : base(radius,radius)
    {
    }

    public override double CalculateSurface()
    {
        return 2 * Math.PI * this.width * this.width;
    }
}