using System;

class Pillars
{
    static byte[,] matrix = new byte[8, 8];

    static int countDots(bool[] crossed)
    {
        int y,x,numberOfDotsLeft = 0, numberOfDotsRight = 0;
        bool countLeft = true, countRight = false;
        for (y = 7; y >= 0; y--)
        {
            if (!crossed[y] && countLeft)
            {
                for (x = 0; x <= 7; x++)                
                    if (matrix[x, y] == 1)
                        numberOfDotsLeft++;                
                continue;
            }
            if (crossed[y] && countLeft == true)
            {
                countRight = true;
                countLeft = false;
                continue;
            }            
            if (!crossed[y] && countRight)
            {
                for (x = 0; x <= 7; x++)
                {
                    if (matrix[x, y] == 1)
                        numberOfDotsRight++;
                }
            }
        }
        if (numberOfDotsLeft == numberOfDotsRight)
            return numberOfDotsRight;
        else
            return 0;
    }

    static void Main()
    {
        int numberOfColums, startingColum = 0;
        int br = 0;        
        byte[] n = new byte[8];        
        for (int i = 0; i <= 7; i++)
            n[i] = byte.Parse(Console.ReadLine());        
        for (int x = 0; x <= 7; x++)
        {
            int y = 0;
            do
            {
                matrix[x, y] = (byte)(n[x] % 2);
                n[x] /= 2;
                y++;
            }
            while (n[x] != 0);
        }
        for (numberOfColums = 1; numberOfColums <= 6; numberOfColums++)
        {
            for (startingColum = 6; startingColum >= numberOfColums; startingColum--)
            {
                bool[] crossed = new bool[8];
                for (int crossedCol = startingColum; crossedCol >= (startingColum - numberOfColums + 1); crossedCol--)
                {
                    crossed[crossedCol] = true;
                }
                br = countDots(crossed);
                if (br != 0)
                {
                    Console.WriteLine(startingColum);
                    Console.WriteLine(br);
                    return;
                }
            }
        }
        Console.WriteLine("No");
    }
}