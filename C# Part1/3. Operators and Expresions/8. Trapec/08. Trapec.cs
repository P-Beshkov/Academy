//08. Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Program
{
    static void Main()
    {
        Console.Write("a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("h: ");
        float h = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Area is: " + (a + b) * h / 2);
    }
}