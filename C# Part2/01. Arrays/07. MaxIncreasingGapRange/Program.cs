//6. Напишете програма, която намира максималната подредица от нарастващи 
//елементи в масив arr[n]. Елементите може и да не са последователни. 
//Пример: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4}  {2, 4, 6, 8}.
using System;
using System.Collections.Generic;
class Program
 {
    static void Main()
    {
        List<int> range = new List<int>(); 
        int currentRange = 1,
            maxRange = 0,
            maxElement = 0;

        Console.WriteLine("Въвеждане на масива");
        for (int i = 0; true; i++)
        {
            Console.Write("{0} елемент = ", i + 1);
            int element = int.Parse(Console.ReadLine());
            if (element != 0) range.Add(element);
            else break;
        }
        foreach (int item in range)
        {
            int minElement = item;
            range.Find(work => work > minElement); 
        }

        //for (int i = arr.Length-1; i >= 1; i--)
        //{
        //    maxElement = arr[i];
        //    for (int j = i - 1; j >= 0; j--)
        //    {
        //        range.FindLast(item => item < maxElement);                
        //        if (arr[j] < maxElement)
        //        {
        //            currentRange++;
        //        }
        //    }
        //    if (currentRange > maxRange)
        //    {
        //        currentRange = maxRange;
        //    }
        //    currentRange = 1;
        //}

    }
}

