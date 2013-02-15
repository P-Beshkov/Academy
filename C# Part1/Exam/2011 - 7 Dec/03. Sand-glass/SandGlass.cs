using System;

class SandGlass
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int i = 0,j = 0;
        for (i = 1; i <= rows; i++)
        {
            Console.Write('*');
        }
        Console.WriteLine();
        for (i = 1; i <= (rows / 2); i++)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write('.');
            }
            for (j = 1; j <= (rows - 2 * i); j++)
            {
                Console.Write('*');
            }
            for (j = 1; j <= i; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (i = 1; i <= (rows / 2 - 1); i++)
        {
            for (j = 1; j <= (rows - 1 - 2 * i) / 2; j++)
            {
                Console.Write('.');
            }
            for (j = 1; j <= (1 + 2 * i); j++)
            {
                Console.Write('*');
            }
            for (j = 1; j <= (rows - 1 - 2 * i) / 2
                ; j++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
        for (i = 1; i <= rows; i++)
        {
            Console.Write('*');
        }
    }
}