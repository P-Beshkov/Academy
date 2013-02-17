using System;

class NextDate
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine()),
            month = int.Parse(Console.ReadLine()),
            year = int.Parse(Console.ReadLine());
        DateTime simpleDate = new DateTime(year, month, day);
        simpleDate = simpleDate.AddDays(1.0);
        Console.WriteLine("{0}.{1}.{2}",simpleDate.Day,simpleDate.Month,simpleDate.Year);
    }
}