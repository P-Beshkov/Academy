//14. Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main(string[] args)
    {
        uint mask = 1;
        int i, q, p;
                
        Console.Write("Число за смяна\t\t\t\t: ");
        uint value = uint.Parse(Console.ReadLine());
        Console.Write("Започващ бит\t\t\t\t: ");
        int startingBit = int.Parse(Console.ReadLine());
        Console.Write("Брой битове за смяна(най-много " + (32 - startingBit) + ")\t: ");
        int numberOfBits = int.Parse(Console.ReadLine());
        Console.Write("Начален бит за смяната(по-малко от " + (33 - numberOfBits) + "-ви): ");
        int startingBit2 = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
                
        uint[] bits = new uint[numberOfBits];
        q = startingBit2;
        for (i = 0; i < numberOfBits; i++)
        {
            mask = 1;
            mask = mask << q;
            mask = mask & value;
            bits[i] = mask ;
            q++;
        }
        i = startingBit;
        q = startingBit2;
        for (p = 0; p < numberOfBits; p++)
        {
            mask = 1;
            mask <<= i;
            mask = mask & value;
            if (mask == 0)
            {
                mask = 1;
                mask <<= q;
                mask = ~mask;
                value &= mask;
            }
            else
            {
                mask = 1;
                mask <<= q;
                value |= mask;
            }
            i++;
            q++;
        }
        for (q = (startingBit), i = 0; i < numberOfBits; i++, q++)
        {
            if (bits[i] == 0)
            {
                bits[i] = 1;
                bits[i] <<= q;
                bits[i] = ~bits[i];
                value &= bits[i];
            }
            else
            {
                bits[i] = 1;
                bits[i] <<= q;
                value |= bits[i];
            }
        }
        Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
    }
}