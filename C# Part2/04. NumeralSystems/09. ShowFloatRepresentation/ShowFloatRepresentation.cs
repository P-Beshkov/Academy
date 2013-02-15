//09. * Write a program that shows the internal binary representation of given
//32-bit signed floating-point number in IEEE 754 format (the C# type float). 
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;
using System.Collections.Generic;
using System.Text;

class ShowFloatRepresentation
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
    
    static private string ConvertFractionToBinary(float fraction,int exponent)
    {
        string result = string.Empty;
        for (int i = 1; i <= 23-exponent; i++)
        {
            fraction *= 2;
            if (fraction > 1.0)
            {
                result += "1";
                fraction -= 1;
            }
            else
            {
                result += "0";
            }
            
        }
        return result;
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
        string floatToBinary = string.Empty;
        float number = 15.6f;
        if (number < 0)
        {
            floatToBinary += "1";
        }
        else
        {
            floatToBinary += "0";
        }
        int wholePart = (int)number;        
        string wholePartBinary = ConvertDecimalToAny(wholePart, 2);
        int exponent = wholePartBinary.Length - 1;
        floatToBinary += "1";
        exponent--;
        string exponentBinary = ConvertDecimalToAny(exponent, 2);
        for (int i = 0; i < 7-exponentBinary.Length; i++)
        {
            floatToBinary += "0";
        }
        floatToBinary += exponentBinary;
        floatToBinary += wholePartBinary.Substring(1);
        float fraction = number - wholePart;
        floatToBinary += ConvertFractionToBinary(fraction,exponent);
        Console.WriteLine("Sign - {0}",floatToBinary.Substring(0,1));
        Console.WriteLine("Exponent - {0}",floatToBinary.Substring(1,8));
        Console.WriteLine("Mantissa - {0}",floatToBinary.Substring(9));       
    }
}