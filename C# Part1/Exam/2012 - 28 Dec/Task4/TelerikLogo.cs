using System;

class Task4
{
    static void PrintLogo(int x)
    {
        int z = (x / 2) + 1,
            lineLenght = (x + z) * 2 - 3,
            startEndDots = z - 1,
            middle = lineLenght - 2 - 2 * startEndDots;
        string firstRow = new String('.', startEndDots) + '*' + new String('.', middle) + '*' + new String('.', startEndDots);
        Console.WriteLine(firstRow);
        startEndDots--;
        middle -= 2;
        z--;
        bool haveZPart = true;
        int insideDots = 1;
        do
        {
            if (haveZPart)
            {
                string partOne = new String('.', startEndDots) + '*' + new String('.', insideDots) + '*';
                string partTwo = '*' + new String('.', insideDots) + '*' + new String('.', startEndDots);
                Console.WriteLine(partOne + new String('.', middle) + partTwo);
                z--;
                startEndDots--;
                insideDots += 2;
                middle -= 2;
            }
            else
            {
                string partOne = new String('.', insideDots) + '*';
                string partTwo = '*' + new String('.', insideDots);
                Console.WriteLine(partOne + new String('.', middle) + partTwo);
                middle -= 2;
                insideDots++;
            }
            haveZPart = (z > 0);
        }
        while (middle >= 1);

        z = x / 2 + 1;
        startEndDots = (lineLenght - 1) / 2;
        middle = -1;
        string row = new String('.', startEndDots) + '*' + new String('.', startEndDots);
        Console.WriteLine(row);
        for (int i = 1; i < x; i++)
        {
            startEndDots--;
            middle += 2;
            row = new String('.', startEndDots) + '*' + new String('.', middle) + '*' + new String('.', startEndDots);
            Console.WriteLine(row);
        }
        for (int i = 2; i < x; i++)
        {
            startEndDots++;
            middle -= 2;
            row = new String('.', startEndDots) + '*' + new String('.', middle) + '*' + new String('.', startEndDots);
            Console.WriteLine(row);
        }
        startEndDots++;
        row = new String('.', startEndDots) + '*' + new String('.', startEndDots);
        Console.WriteLine(row);
    }

    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        PrintLogo(x);        
    }
}
    
//static void SecondPart(int x)
//{
//    int z = (x >> 1) + 1;
//    int lineLenght = ((x + z) << 1) - 3;
//    int startEndDots = (lineLenght - 1) >> 1;
//    int middle = -1;
//    string row = new String('.', startEndDots) + '*' + new String('.', startEndDots);
//    Console.WriteLine(row);
        
//    for (int i = 1; i < x; i++)
//    {
//        startEndDots--;
//        middle += 2;
//        row = new String('.', startEndDots) + '*' + new String('.', middle) + '*' + new String('.', startEndDots);
//        Console.WriteLine(row);
//    }
//    for (int i = 2; i < x; i++)
//    {
//        startEndDots++;
//        middle -= 2;
//        row = new String('.', startEndDots) + '*' + new String('.', middle) + '*' + new String('.', startEndDots);
//        Console.WriteLine(row);           
//    }
//    startEndDots++;
//    row = new String('.', startEndDots) + '*' + new String('.', startEndDots);
//    Console.WriteLine(row);
//}
//int z = (x + 1) / 2;
//int lineLenght = 2 * (z + x) - 4;
//String workStringSide = new String('.', z - 1),
//workStringMiddle = new String('.', 2 * x - 3),
//firstRow = workStringSide + "*" + workStringMiddle + "*" + workStringSide;
//Console.WriteLine(firstRow);
//int firstPartDots = z - 2,
//middlePartDots = 2 * x - 5,
//sideDots;
//if (x == 3)
//{
//    Console.WriteLine("*.*.*.*");
//    sideDots = 2;
//}
//else
//{
//    for (sideDots = 1; middlePartDots >= 3;)
//    {
//        if (firstPartDots > 0)
//        {
//            String start = new String('.', firstPartDots);
//            Console.Write(start);
//        }
//        if (firstPartDots >= 0)
//        {
//            Console.Write("*");
//        }
//        workStringSide = new String('.', sideDots);
//        workStringMiddle = new String('.', middlePartDots); 
//        Console.Write(workStringSide + "*" + workStringMiddle + "*" + workStringSide);
//        if (firstPartDots >= 0)
//        {
//            Console.Write("*");
//        }
//        if (firstPartDots > 0)
//        {
//            String start = new String('.', firstPartDots);
//            Console.Write(start);
//        }
//        Console.WriteLine();
//        firstPartDots--;
//        if (firstPartDots <= -2)
//        {
//            sideDots++;
//        }
//        else
//        {
//            sideDots += 2;
//        }
//        middlePartDots -= 2;
//    }
//    String buffer = new String('.', sideDots);
//    Console.WriteLine(buffer + "*" + "." + "*" + buffer);
//}
//sideDots++;
//middlePartDots = -1;
//for (int i = 1; i < x; i++)
//{
//    String sides = new String('.', sideDots);
//    Console.Write(sides);
//    if (middlePartDots > 0)
//    {
//        Console.Write("*");
//        Console.Write(new String('.', middlePartDots));
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(sides);
//    sideDots--;
//    middlePartDots += 2;
//}
//for (int i = 1; i <= x; i++)
//{
//    String sides = new String('.', sideDots);
//    Console.Write(sides);
//    if (middlePartDots == -1)
//    {
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write("*");
//        Console.Write(new String('.', middlePartDots));
//        Console.Write("*");
//    }
//    Console.WriteLine(sides);
//    middlePartDots -= 2;
//    sideDots++;
//}
//Console.ReadKey();