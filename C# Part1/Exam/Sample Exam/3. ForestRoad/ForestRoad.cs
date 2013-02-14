using System;

class ForestRoad
{
    static void Main()
    {
        int numberOfLines = int.Parse(Console.ReadLine());
        int i,j;
        for (j = 1; j <= (numberOfLines - 1); j++)
        {
            for (i = 1; i <= (j-1); i++)
                Console.Write('.');
            Console.Write('*');
            for (i = (numberOfLines - j); i >= 1; i--)
                Console.Write('.');
            Console.WriteLine();
        }
        for (j = 1; j <= numberOfLines; j++)
        {
            for (i=(numberOfLines-j); i>=1;i--)
                Console.Write('.');
            Console.Write('*');
            for (i=1;i<=(j-1);i++)
                Console.Write('.');
            Console.WriteLine();
        }
    }
}