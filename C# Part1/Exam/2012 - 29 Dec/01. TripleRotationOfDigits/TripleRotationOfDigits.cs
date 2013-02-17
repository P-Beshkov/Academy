using System;
using System.Text;

class TripleRotationOfDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        StringBuilder workString = new StringBuilder(Convert.ToString(number));
        char lastDigit = workString[workString.Length-1];        
        for (int i = 0; i < 3; i++)
        {
            lastDigit = workString[workString.Length - 1];
            if (lastDigit != '0')
            {
                workString.Remove(workString.Length - 1, 1);
                workString.Insert(0, lastDigit);
            }
            else
            {
                workString.Remove(workString.Length - 1, 1);
            }
        }
        Console.WriteLine(workString);
    }
}