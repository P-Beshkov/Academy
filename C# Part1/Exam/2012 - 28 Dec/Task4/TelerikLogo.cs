using System;

class Task4
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int z = (x + 1) / 2;
        int lineLenght = 2 * (z + x) - 4;
        String workStringSide = new String('.', z - 1),
            workStringMiddle = new String('.', 2 * x - 3),
            firstRow = workStringSide + "*" + workStringMiddle + "*" + workStringSide;

        Console.WriteLine(firstRow);

        int firstPartDots = z - 2,
            middlePartDots = 2 * x - 5,
            sideDots;
        if (x == 3)
        {
            Console.WriteLine("*.*.*.*");
            sideDots = 2;
            
        }
        else
        {
            for (sideDots = 1; middlePartDots >= 3; )
            {
                if (firstPartDots > 0)
                {
                    String start = new String('.', firstPartDots);
                    Console.Write(start);
                }
                if (firstPartDots >= 0)
                {
                    Console.Write("*");
                }
                workStringSide = new String('.', sideDots);
                workStringMiddle = new String('.', middlePartDots); 
                
                Console.Write(workStringSide+"*"+workStringMiddle+"*"+workStringSide);
                if (firstPartDots >= 0)
                {
                    Console.Write("*");
                }
                if (firstPartDots > 0)
                {
                    String start = new String('.', firstPartDots);
                    Console.Write(start);
                }
                Console.WriteLine();
                firstPartDots--;
                if (firstPartDots <= -2)
                {
                    sideDots++;
                }
                else
                {
                    sideDots += 2;
                }
                middlePartDots -= 2;
            }
            String buffer = new String('.', sideDots);
            Console.WriteLine(buffer + "*" + "." + "*" + buffer);
        }


        sideDots++;
        middlePartDots = -1;
        for (int i = 1; i < x; i++)
        {
            String sides = new String('.', sideDots);
            Console.Write(sides);
            if (middlePartDots > 0)
            {
                Console.Write("*");
                Console.Write(new String('.', middlePartDots));
                Console.Write("*");
            }
            else
            {
                Console.Write("*");
            }
            Console.WriteLine(sides);
            sideDots--;
            middlePartDots += 2;
        }
        for (int i = 1; i <= x; i++)
        {
            String sides = new String('.', sideDots);
            Console.Write(sides);
            if (middlePartDots == -1)
            {
                Console.Write("*");
            }

            else
            {
                Console.Write("*");
                Console.Write(new String('.', middlePartDots));
                Console.Write("*");
            }
            Console.WriteLine(sides);
            middlePartDots -= 2;
            sideDots++;
        }
        Console.ReadKey();
    }
}

