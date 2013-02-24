/*01. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the 
* Euclidian 3D space. Implement the ToString() to enable printing a 3D point. 
02. Add a private static read-only field to hold the start of the coordinate 
* system – the point O{0, 0, 0}. Add a static property to return the point O.*/

using System;

public struct Point3D
{
    private static readonly Point3D start = new Point3D(0, 0, 0);

    public static Point3D Start
    {
        get
        {
            return start;
        }
    }

    public double X { get; set; }

    public double Y { get; set; }

    public double Z { get; set; }

    public Point3D(double x, double y, double z) : this()
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public override string ToString()
    {
        return string.Format("X: {0}\nY: {1}\nZ: {2}", X, Y, Z);
    }
}

class Test
{
    static void Main()
    {
        Point3D testPoint = new Point3D(3, 4, 6);
        Point3D secondPoint = new Point3D(-3.2, -10.23, -23.2);
        Console.WriteLine("First point:\n"+testPoint);
        Console.WriteLine("Second point"+secondPoint);
        Console.WriteLine("Distance = {0}",Points3DOperations.Distance(testPoint,secondPoint));
        PathStorage.LoadPaths();
        Console.WriteLine(PathStorage.ToString());
    }
}