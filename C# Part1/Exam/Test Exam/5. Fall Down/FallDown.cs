using System;

class Program
{
    static void Main()
    {
        byte i, x, br = 0, newNumber = 0;
        byte[,] matrix = new byte[8, 8];
        byte[] n = new byte[8];
        for (i = 0; i <= 7; i++)
            n[i] = byte.Parse(Console.ReadLine());
        int y;
        for (x = 0; x <= 7; x++)
        {
            y = 0;
            do
            {
                matrix[x, y] = (byte)(n[x] % 2);
                n[x] /= 2;
                y++;
            }
            while (n[x] != 0);
        }
        for (y = 0; y <= 7; y++)
        {
            br = 0;
            for (x = 0; x <= 7; x++)
                if (matrix[x, y] == 1)
                    br++;
            newNumber = 0;
            for (i = 0; i < br; i++)
                newNumber = (byte)(newNumber + Math.Pow(2, i));
            newNumber <<= 8 - br;
            for (x = 0; x <= 7; x++)
            {
                if (newNumber == 0)
                    matrix[x, y] = 0;
                else
                {
                    matrix[x, y] = (byte)(newNumber % 2);
                    newNumber /= 2;
                }
            }
        }
        for (x = 0; x <= 7; x++)
        {
            for (y = 0; y <= 7; y++)
                if (matrix[x, y] == 1)
                    newNumber = (byte)(newNumber + Math.Pow(2, y));
            Console.WriteLine(newNumber);
            newNumber = 0;
        }
    }
}
        //for (x = 0; x <= 7; x++)
        //{
        //    for (i = 1; i <= 7; i++)
        //    {
        //        y = 0;
        //        do
        //        {
        //            if (matrix[x, y] == 0)
        //            {
        //                matrix[x, y] = matrix[x, (y + 1)];
        //                matrix[x, (y + 1)] = 0;
        //            }
        //            y++;
        //        }
        //        while (y <= 6);
        //    }
        //}
        //for (y = 7; y >= 0; y--)
        //{
        //    for (x = 0; x <= 7; x++)
        //    {
        //        if (matrix[x, y] == 1)
        //            newNumber = (byte)(newNumber + (byte)Math.Pow(2, x));
        //    }
        //    Console.WriteLine(newNumber);
        //}
    
