﻿/*01. Define abstract class Shape with only one abstract method CalculateSurface() 
* and fields width and height. Define two new classes Triangle and Rectangle that 
* implement the virtual method and return the surface of the figure 
* (height*width for rectangle and height*width/2 for triangle). Define class Circle 
* and suitable constructor so that at initialization height must be kept equal to 
* width and implement the CalculateSurface() method. Write a program that tests the
* behavior of  the CalculateSurface() method for different shapes 
* (Circle, Rectangle, Triangle) stored in an array. */

using System;

class Program
{
    static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Circle(3.43),
            new Triangle(10,5),
            new Rectangle(3.23,32.25)
        };
        foreach (Shape item in shapes)
        {
            Console.WriteLine("I'm {0} with surface = {1:F3}", item.GetType(), item.CalculateSurface());
        }
    }
}