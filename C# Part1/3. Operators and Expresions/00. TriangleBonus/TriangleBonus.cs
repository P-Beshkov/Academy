using System;

class Program
{
    static void Main()
    {
        int x,value;
        int N = int.Parse(Console.ReadLine());
        for (value = 0; value <= N; value++)
        {
            for (x = 1; x <= N - value; x++)
                Console.Write(" ");
            for (x = 1; x <= value; x++)
                Console.Write("*");
            Console.Write("|");
            for (x = 1; x <= value; x++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}