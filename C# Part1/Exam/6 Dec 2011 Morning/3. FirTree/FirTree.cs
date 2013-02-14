using System;

class FirTree
{
    static void Main()
    {
        byte N = byte.Parse(Console.ReadLine());
        int i;
        for (i = 0; i < (N - 1); i++)
        {
            Console.Write(new string('.', N - 2 - i));
            Console.Write(new string('*',i * 2 + 1));
            Console.Write(new string('.', N - 2 - i));
            Console.WriteLine();
        }
        Console.Write(new string('.', N - 2) + '*' + new string('.', N - 2));
    }
}