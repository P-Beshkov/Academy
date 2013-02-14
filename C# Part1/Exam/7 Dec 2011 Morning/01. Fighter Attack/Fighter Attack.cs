using System;

class Program
{
    static int px1 = int.Parse(Console.ReadLine());
    static int py1 = int.Parse(Console.ReadLine());
    static int px2 = int.Parse(Console.ReadLine());
    static int py2 = int.Parse(Console.ReadLine());

    static bool isIn(int x, int y)
    {
        if ((x >= px1 && x <= px2) && (y >= py1 && y <= py2))
            return true;
        else
            return false;
    }

    static void Main()
    {
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int damage = 0;

        if (px2 < px1)
        {
            px1 += px2;
            px2 = px1 - px2;
            px1 -= px2;
        }
        if (py2 < py1)
        {
            py1 += py2;
            py2 = py1 - py2;
            py1 -= py2;
        }
        fx += d;
        if (isIn(fx, fy))
            damage += 100;
        if (isIn(fx, (fy + 1)))
            damage += 50;
        if (isIn(fx, (fy - 1)))
            damage += 50;
        if (isIn(fx + 1, fy))
            damage += 75;
        Console.WriteLine(damage + "%");
    }
}