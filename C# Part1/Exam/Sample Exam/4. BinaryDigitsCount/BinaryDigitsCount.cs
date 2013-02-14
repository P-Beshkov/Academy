using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte digit = byte.Parse(Console.ReadLine());        
        uint numbersToCount = uint.Parse(Console.ReadLine());
        int digitCount = 0;         
        uint newNumber;
    
        for (int i = 1; i <= numbersToCount; i++)
        {
            newNumber = uint.Parse(Console.ReadLine());
            digitCount = 0;
            do
            {
                if (newNumber % 2 == digit)
                    digitCount++;
                newNumber >>= 1;
            }
            while (newNumber != 0);
            Console.WriteLine(digitCount);
        }   
    }
}