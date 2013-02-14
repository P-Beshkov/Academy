//06. Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class Program
{
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        Console.Write("The point is in the circle: ");
        Console.WriteLine((x < 5 && x > -5) && (y < 5 && y > -5));
    }
}