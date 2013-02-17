using System;

class Sheets
{
    static void Main()
    {
        int sheetsCount = int.Parse(Console.ReadLine());
        int size = 10;
        do
        {
            bool isBitOne = (sheetsCount & 1) == 1;
            if (!isBitOne)
            {
                Console.WriteLine("A{0}", size);
            }
            size--;
            sheetsCount >>= 1;
        }
        while (sheetsCount != 0);        
        for (int i = size; i >= 0; i--)
        {
            Console.WriteLine("A{0}", i);
        }        
    }
}