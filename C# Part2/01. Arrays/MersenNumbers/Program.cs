using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
class Program
{
    //static bool isPrime(BigInteger a)
    //{
    //    BigInteger border = a / 2;
    //    for (BigInteger v = 2; v <= border; v++)
    //    {            
    //        if (a % v == 0)
    //            return false;
    //    }
    //    return true;
    //}
    //static bool isMersen(BigInteger p)
    //{
    //    BigInteger number = 2;

    //    if (isPrime(number - 1))
    //    {
    //        return true;
    //    }
    //    return false;
    //}
    static void Main()
    {
        int? vara=null;
        Console.WriteLine(vara.GetValueOrDefault());
        StreamWriter result = new StreamWriter("result.txt");
        bool isPrime = true;
        BigInteger border, j,v;
        for (BigInteger i = 1; i <= 31; i++)
        {
            border = i / 2;
            isPrime = true;
            for (j = 2; j <= border; j++)
            {
                if (i % j == 0)
                    isPrime = false;
            }
            if (isPrime)
            {
                BigInteger number = 2;
                for (j = 2; j <= i; j++)
                {
                    number *= 2;
                }
                border = number / 2;
                number--;
                isPrime = true;
                for (v = 2; v <= border; v++)
                {
                    if (number % v == 0)
                        isPrime = false;
                }
                if (isPrime)
                    result.WriteLine(number);
            }
        }
        result.Close();
    }
}
