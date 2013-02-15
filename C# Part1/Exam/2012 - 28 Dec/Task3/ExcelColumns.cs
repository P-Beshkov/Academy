using System;

class Task3
{
    static void Main()
    {
        int arraySize = int.Parse(Console.ReadLine());
        char[] exelSymbols = new char[arraySize];
        long decimalIndex = 0;
        for (int i = (arraySize - 1); i >= 0; i--)
        {
            exelSymbols[i] = Convert.ToChar(Console.ReadLine());
        }
        long level = 1;
        for (int i = 0; i < exelSymbols.Length; i++)
        {
            decimalIndex += (exelSymbols[i] - '@') * level;
            level *= 26;
        }
        Console.WriteLine(decimalIndex);
    }
}

