//04. Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; 
//Two sides and an angle between them. Use System.Math.

using System;

class CalculateTriangleSurface
{
    static private double GetTriangleSurface(double side, double altitude)
    {
        double surface;
        surface = side * altitude / 2;
        return surface;
    }

    static private double GetTriangleSurface(double sideA, double sideB, double sideC)
    {
        double surface;
        double p = (sideA + sideB + sideC) / 2;
        surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        return surface;
    }

    static private double GetTriangleSurface(double sideA, double sideB, int andgleInDegrees)
    {
        double surface;
        double sideC;
        double angleInRadian = (andgleInDegrees * Math.PI) / 180;
        sideC = sideA * sideB * Math.Sin(angleInRadian) / 2;
        surface = GetTriangleSurface(sideA, sideB, sideC);
        return surface;
    }

    static void Main()
    {
        double surface = 0;
        double sideA, sideB, sideC, altitude;
        int angle;

        Console.WriteLine("Enter a side and an altitude to it:");
        sideA = double.Parse(Console.ReadLine());
        altitude = double.Parse(Console.ReadLine());
        surface = GetTriangleSurface(sideA, altitude);
        Console.WriteLine("Surface is = {0}", surface);

        Console.WriteLine("Enter three sides:");
        sideA = double.Parse(Console.ReadLine());
        sideB = double.Parse(Console.ReadLine());
        sideC = double.Parse(Console.ReadLine());
        surface = GetTriangleSurface(sideA, sideB, sideC);
        Console.WriteLine("Surface is = {0}", surface);

        Console.WriteLine("Enter two sides and angle between them:");
        sideA = double.Parse(Console.ReadLine());
        sideB = double.Parse(Console.ReadLine());
        angle = int.Parse(Console.ReadLine());
        surface = GetTriangleSurface(sideA, sideB, angle);
        Console.WriteLine("Surface is = {0}", surface);
    }
}