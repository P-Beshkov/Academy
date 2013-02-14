using System;

class Program
{
    static void Main()
    {
        int numbersToRead = int.Parse(Console.ReadLine());
        long[] allNumbers = new long[numbersToRead];
        int i,br = 1;
        for (i = 0; i < numbersToRead; i++)
            allNumbers[i] = long.Parse(Console.ReadLine());
        Array.Sort(allNumbers);
        for (i = 1; i < numbersToRead; i++)
        {
            if (allNumbers[i] == allNumbers[i - 1])
                br++;
            else if (br % 2 == 1)
            {
                Console.WriteLine(allNumbers[i - 1]);
                return;
            }
            else
                br = 1;
        }
        Console.WriteLine(allNumbers[i-1]);
    }
}
        //int numbersToRead = int.Parse(Console.ReadLine());
        //int i,j;
        //long newNumber;        
        //long[] allNumbers = new long[numbersToRead];
        //int[] density = new int[numbersToRead];
        //newNumber = long.Parse(Console.ReadLine());
        //allNumbers[0] = newNumber;
        //density[0]++;
        //for (i = 1; i < numbersToRead; i++)
        //{
        //    newNumber = 20;// long.Parse(Console.ReadLine());
        //    for (j = 0; j < i; j++)
        //    {
        //        if (allNumbers[j] == newNumber)
        //        {                    
        //            density[j]++;
        //            break;
        //        }
        //    }
        //    if (j==i)
        //    {
        //        allNumbers[j] = newNumber;
        //        density[j]++;                
        //    }            
        //}
        //if (numbersToRead == 1)
        //{
        //    Console.WriteLine(allNumbers[0]);
        //}
        //else
        //    for (i = 0; density[i] != 0; i++)
        //    {
        //        if (density[i] % 2 == 1)
        //        {
        //            Console.WriteLine(allNumbers[i]);
        //            return;
        //        }
        //    }
 