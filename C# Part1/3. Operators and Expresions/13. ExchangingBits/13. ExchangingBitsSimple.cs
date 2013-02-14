//13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Number to exchange it's bits: ");
        uint value = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
        uint mask = 1;
        int i,p;
        uint[] bits = new uint[3];
        
        for (p = 24, i = 0; i <= 2; i++, p++)   //Запазване на старшите битове
        {
            mask = 1;
            mask = mask << p;
            mask = mask & value;
            bits[i] = mask >> 21;
        }
        for (i = 3,p = 24; i <= 5; i++,p++)     //Смяна на старшите със младшите
        {
            mask = 1;
            mask <<= i;
            mask = mask & value;
            if (mask == 0)
            {
                mask = 1;
                mask <<= p;
                mask = ~mask;
                value = value & mask;
            }
            else
            {
                mask <<= 21;
                value |= mask;
            }
        }
        for (p = 3, i = 0; i <= 2; i++, p++)    //Смяна на младшите със старшите
        {
            if (bits[i] == 0)
            {
                bits[i] = 1;
                bits[i] <<= p;
                bits[i] = ~bits[i];
                value = value & bits[i];
            }
            else
                value |= bits[i];                   
        }
        Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
    }
}