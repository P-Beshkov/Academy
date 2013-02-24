/*03. Write a static class with a static method to calculate the distance 
* between two points in the 3D space. */

using System;

static class Points3DOperations
{
    public static double Distance(Point3D first, Point3D second)
    {
        double result,
        distX = Math.Abs(first.X - second.X),
        distY = Math.Abs(first.Y - second.Y),
        distZ = Math.Abs(first.Z - second.Z);
        result = Math.Sqrt(distX * distX + distY * distY + distZ * distZ);
        return result;
    }
}