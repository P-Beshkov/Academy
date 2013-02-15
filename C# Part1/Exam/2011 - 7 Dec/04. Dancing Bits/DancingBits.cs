using System;

class DancingBits
{ 
    static void Main()
    {
        int neededBits = int.Parse(Console.ReadLine());
        int numbersCount = int.Parse(Console.ReadLine());
        int currentNumber = 0;
        int i, j = 0, dancingBits = 0;
        int prevBit = 0, currentBitCount = 1;         
        
        int[] bits = new int[31];
        for (i = 1; i <= numbersCount; i++)
        {
            currentNumber = int.Parse(Console.ReadLine());
            j = 0;
            do
            {
                if (currentNumber % 2 == 1)
                    bits[j] = 1;
                currentNumber /= 2;
                j++;
            }
            while (currentNumber != 0);
            j--;
            if (i == 1)
            {
                prevBit = bits[j];
                bits[j] = 0;
                j--;
            }
            for (; j >= 0; j--)
            {
                if (prevBit == bits[j])
                    currentBitCount++;
                else
                {
                    if (currentBitCount == neededBits)
                        dancingBits++;
                    currentBitCount = 1;
                }
                prevBit = bits[j];
                bits[j] = 0;
            }
        }
        if (currentBitCount == neededBits)
            dancingBits++;
        Console.WriteLine(dancingBits);
    }
}