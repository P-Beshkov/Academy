using System;

class Lines
{
    static void Main()
    {
        byte i, x, dotCount = 0;
        byte[,] matrix = new byte[8, 8];
        byte[] n = new byte[8];
        byte[] count = new byte[9];
        bool inLine;
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
        
        for (x = 0; x <= 7; x++)
        {
            inLine = false;
            dotCount = 0;
            for (y = 0; y <= 7; y++)
            {
                if (matrix[x, y] == 1 && inLine == false)
                    inLine = true;
                if (matrix[x, y] == 1 && inLine == true)
                    dotCount++;
                if (matrix[x, y] == 0)
                {
                    count[dotCount]++;
                    dotCount = 0;
                }
            }
            if (matrix[x, (y-1)] == 1)
                count[dotCount]++;
        }
        for (y = 0; y <= 7; y++)
        {
            inLine = false;
            dotCount = 0;
            for (x = 0; x <= 7; x++)
            {
                if (matrix[x, y] == 1 && inLine == false)
                    inLine = true;
                if (matrix[x, y] == 1 && inLine == true)
                    dotCount++;
                if (matrix[x, y] == 0)
                {
                    count[dotCount]++;
                    dotCount = 0;
                }
            }
            if (matrix[(x-1), y] == 1)
                count[dotCount]++;
        }

        count[1] /= 2;
        for (i = 8; i >= 1; i--)
        {
            if (count[i] > 0)
            {
                Console.WriteLine(i);
                Console.WriteLine(count[i]);
                return;
            }            
        }
    }
}
//    if (matrix[x, y] == 1 && inLine == false)
//        inLine = true;
//    if (matrix[x, y] == 1 && inLine == true)
//        dotCount++;
//    if (matrix[x, y] == 0)
//    {
//        if (dotCount > prevDotCount)
//            prevDotCount = dotCount;
//        else if (dotCount == prevDotCount)
//        {
//            br++;
//            prevDotCount = dotCount;
//        }
//        inLine = false;
//        dotCount = 0;
//    }
//}
//if (dotCount > prevDotCount)
//    prevDotCount = dotCount;
//if (prevDotCount > max)
//{
//    max = prevDotCount;
//    br = 0;
//}
//if (prevDotCount == max && prevDotCount > 0)
//    br++;      
//for (x = 0; x <= 7; x++)
//        {
//            for (y = 7; y >= 0; y--)
//                Console.Write(matrix[x, y] + " ");
//            Console.WriteLine();
//        }      