//02. Write a method GetMax() with two parameters that returns the bigger 
//of two integers. Write a program that reads 3 integers from the console
//and prints the biggest of them using the method GetMax().

using System;

class MethodGetMax
{
    static private T GetMax<T>(T var1, T var2) where T : IComparable<T>
    {
        if (var1.CompareTo(var2) >= 0)
        {
            return var1;
        }
        else
        {
            return var2;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter 3 integer values");
        int intValue1 = int.Parse(Console.ReadLine()),
        intValue2 = int.Parse(Console.ReadLine()),
        intValue3 = int.Parse(Console.ReadLine());
        int temp = GetMax<int>(intValue1, intValue2);
        Console.WriteLine("Biggest number is {0}", GetMax<int>(temp, intValue3));
    }
}