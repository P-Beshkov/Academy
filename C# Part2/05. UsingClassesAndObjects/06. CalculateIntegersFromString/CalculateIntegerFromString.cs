//07. You are given a sequence of positive integer values written into a string, 
//separated by spaces. Write a function that reads these values from given string 
//and calculates their sum. Example: string = "43 68 9 23 318" -> result = 461

using System;

class CalculateIntegerFromString
{
    static private int GetSumFromString(string rawData)
    {
        int sum = 0;
        string tempDigits = string.Empty;

        foreach (char item in rawData)
        {
            if (char.IsDigit(item))
            {
                tempDigits += item;
            }
            else
            {
                sum += int.Parse(tempDigits);
                tempDigits = string.Empty;
            }
        }
        sum += int.Parse(tempDigits);
        return sum;
    }
    static void Main()
    {
        string rawData = "43 68 9 23 318";
        Console.WriteLine("string: {0}",rawData);
        Console.WriteLine("Sum of it's integers = {0}",GetSumFromString(rawData));
    }
}