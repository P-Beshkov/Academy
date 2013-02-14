//09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class Program
{
    static void Main()
    {
        int pointX = int.Parse(Console.ReadLine());
        int pointY = int.Parse(Console.ReadLine());
        bool inCircle;
        bool inRectangle;

        inCircle = (pointX > -2 && pointX < 4) && (pointY < 4 && pointY > -1);
        inRectangle = (pointX < 7 && pointX > 1) && (pointY < -1 && pointY > -3);

        Console.WriteLine("In circle and out of rectangle: " + (inCircle && !inRectangle));
    }
}
