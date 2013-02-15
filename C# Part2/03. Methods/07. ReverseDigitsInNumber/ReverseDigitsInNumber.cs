//07. Write a method that reverses the digits of given decimal number. Example: 256 -> 652

using System;

class ReverseDigitsInNumber
{
    static private decimal ReverseDigits(decimal oldValue)
    {

        int dotIndex;
        decimal newValue = 0;        
        string digits = oldValue.ToString();
        char[] reversedDigits = digits.ToCharArray();
        Array.Reverse(reversedDigits);
        dotIndex = Array.IndexOf(reversedDigits, '.');
        decimal exponent = 1;
        if (dotIndex == -1)
        {
            dotIndex = reversedDigits.Length;
        }
        for (int i = dotIndex - 1; i >= 0; i--)
        {
            newValue += (reversedDigits[i] - '0') * exponent;
            exponent *= 10;
        }
        if (dotIndex != -1)
        {
            exponent = 0.1M;
            for (int i = dotIndex + 1; i < reversedDigits.Length; i++)
            {
                newValue += (reversedDigits[i] - '0') * exponent;
                exponent *= 0.1M;
            }
        }
        return newValue;
    }

    static void Main()
    {
        
        decimal value = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed is: {0}",ReverseDigits(value));
    }
}