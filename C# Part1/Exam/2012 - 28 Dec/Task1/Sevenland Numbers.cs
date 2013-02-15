using System;
using System.Text;

class Task1
{
    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    static int convertToDecimal(int k)
    {
        int result = 0;
        int level = 1;
        do
        {
            int lastDigit = k % 10;
            result += lastDigit * level;
            level *= 7;
            k = k / 10;
        }
        while (k != 0);
        return result;
    }

    static string convertToSevenBase(int k)
    {
        StringBuilder buffer = new StringBuilder();
        
        do
        {
            int lastDigit = k % 7;
            buffer.Append(lastDigit);
            k = k / 7;
        }
        while (k != 0);
        return ReverseString(buffer.ToString());
    }

    static void Main()
    {
        int k = int.Parse(Console.ReadLine());        
        int kPlusOne = convertToDecimal(k);
        kPlusOne++;
        Console.WriteLine(convertToSevenBase(kPlusOne));
    }
}