﻿//05. Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Text;

class HexToBinary
{
    static private string ConvertAnyToAny(string number, int inputBase, int outputBase)
    {
        int resultInDecimal = ConvertAnyToDecimal(number, inputBase);
        string resultInNeededBase = ConvertDecimalToAny(resultInDecimal, outputBase);
        return resultInNeededBase;
    }

    static private int ConvertAnyToDecimal(string number, int inputBase)
    {
        int result = 0;
        int pow = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int value;
            value = ExtractValue(number[i]);
            result += value * pow;
            pow *= inputBase;
        }

        return result;
    }

    static private string ConvertDecimalToAny(int number, int outputBase)
    {
        List<char> result = new List<char>();
        do
        {
            int nextDigit = number % outputBase;
            if (nextDigit <= 9)
            {
                nextDigit += 48;
            }
            else
            {
                nextDigit += 55;
            }
            result.Add((char)nextDigit);
            number /= outputBase;
        }
        while (number != 0);
        result.Reverse();
        StringBuilder stringResult = new StringBuilder();
        foreach (char item in result)
        {
            stringResult.Append(item);
        }
        return stringResult.ToString(0, stringResult.Length);
    }

    static private int ExtractValue(char symbol)
    {
        if (symbol >= 'A')
        {
            return symbol - 'A' + 10;
        }
        else
        {
            return symbol - '0';
        }
    }

    static void Main()
    {
        string input = "13231FAD9";
        int inputBase = 16;
        int outputBase = 2;

        string output = ConvertAnyToAny(input, inputBase, outputBase);
        Console.WriteLine("{0}({1}) in ({2}) is {3}", input, inputBase, outputBase, output);
    }
}