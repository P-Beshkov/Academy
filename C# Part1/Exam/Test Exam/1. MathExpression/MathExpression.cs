using System;


class Program
{
    static void Main()
    {
        decimal N = decimal.Parse(Console.ReadLine());
        decimal M = decimal.Parse(Console.ReadLine());
        decimal P = decimal.Parse(Console.ReadLine());
        decimal sum1, sum2, sum;
        sum1 = N * N + (1 / (M * P)) + 1337;
        sum2 = N - 128.523123123M * P;
        sum = sum1 / sum2 + (decimal)Math.Sin((long)M % 180);
        Console.Write("{0:F6}", sum);
    }
}