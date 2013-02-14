using System;

class SubsetSums
{ 
    static long sumOriginal = long.Parse(Console.ReadLine());
    static int countOfAllNumbers = int.Parse(Console.ReadLine());
    static int brSums = 0;
    static int[] position = new int[17];
    static long[] values = new long[17];
    

    static void GenerateCombinaton(int genForPosition, int after, int numbersToCombine)
    {
        if (genForPosition > numbersToCombine)
        { 
            long checkSum = 0;
            for (genForPosition = 0; genForPosition < numbersToCombine; genForPosition++)
            {
                checkSum += values[position[genForPosition]];
            }
            if (sumOriginal == checkSum)
                brSums++;
            return;
        }
        for (int p = (after + 1); p <= countOfAllNumbers; p++)
        {
            position[genForPosition - 1] = p;
            GenerateCombinaton(genForPosition + 1, p,  numbersToCombine);
        }
    }

    static void Main()
    {        
        for (int i = 1; i <= countOfAllNumbers; i++)
        {
            values[i] = long.Parse(Console.ReadLine());
        }        
        if (countOfAllNumbers == 1 && sumOriginal == values[1])
            Console.WriteLine("1");
        else
        {
            for (int numbersToCombine = 1; numbersToCombine <= countOfAllNumbers; numbersToCombine++)
            {
                GenerateCombinaton(1, 0, numbersToCombine);
            }
            Console.WriteLine(brSums);
        }
    }
}