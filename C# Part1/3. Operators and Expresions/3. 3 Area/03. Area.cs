//03. Write an expression that calculates rectangle’s area by given width and height

using System;

class Program
{
    static void Main()
    { 
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("Area is: " + (width * height));
    }
}