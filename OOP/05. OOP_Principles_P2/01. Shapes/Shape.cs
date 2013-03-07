public abstract class Shape
{
    abstract public double CalculateSurface();

    protected double width;
    protected double height;

    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
}