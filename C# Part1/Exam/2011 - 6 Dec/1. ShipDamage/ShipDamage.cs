using System;

class ShipDamage
{
    static int Sx1 = int.Parse(Console.ReadLine());
    static int Sy1 = int.Parse(Console.ReadLine());
    static int Sx2 = int.Parse(Console.ReadLine());
    static int Sy2 = int.Parse(Console.ReadLine());

    static int checkDamage(int shootsX, int shootsY)
    {
        int damage = 0;
        if (shootsX < Sx1 || shootsX > Sx2)
            damage += 0;
        else if ((shootsX == Sx1 || shootsX == Sx2) && (shootsY == Sy1 || shootsY == Sy2))
            damage += 25;
        else if ((shootsX == Sx1 || shootsX == Sx2) && (shootsY < Sy1 && shootsY > Sy2))
            damage += 50;
        else if ((shootsX > Sx1 && shootsX < Sx2) && (shootsY == Sy1 || shootsY == Sy2))
            damage += 50;
        else if ((shootsX > Sx1 && shootsX < Sx2) && (shootsY < Sy1 && shootsY > Sy2))
            damage += 100;
        return damage;
    }

    static void Main()
    { 
        int H = int.Parse(Console.ReadLine());
        int Cx, Cy;
        int shootsX, shootsY,damage = 0;
        if (Sx1 > Sx2)
        {
            shootsX = Sx1;
            Sx1 = Sx2;
            Sx2 = shootsX;
        }
        if (Sy1 < Sy2)
        {
            shootsY = Sy1;
            Sy1 = Sy2;
            Sy2 = shootsY;
        }
        for (int i = 1; i <= 3; i++)
        {
            Cx = int.Parse(Console.ReadLine());
            Cy = int.Parse(Console.ReadLine());
            shootsX = Cx;
            if (Cy > H)
                shootsY = Cy - 2 * Math.Abs(H - Cy);
            else 
                shootsY = Cy + 2 * Math.Abs(H - Cy);            
            damage += checkDamage(shootsX, shootsY);
        }
        Console.WriteLine(damage + "%");
    }
}