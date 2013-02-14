using System;

class Trapezoid
{
    static void Main()
    {
        int i, j, p;
        int N = int.Parse(Console.ReadLine());

        for (i = 1; i <= (N + 1); i++)
        {
            for (j = (N + 1 - i); j >= 1; j--)
                Console.Write('.');
            if (i == 1)
                for (p = 1; p <= N; p++)
                    Console.Write('*');
            else if (i == (N + 1))
                for (p = 1; p <= (2 * N); p++)
                    Console.Write('*');
            else
            {
                Console.Write('*');
                for (p = 1; p <= (N - 3 + i); p++)
                    Console.Write('.');
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
    
}