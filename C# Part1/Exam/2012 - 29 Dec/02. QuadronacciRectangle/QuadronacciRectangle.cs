using System;
using System.Collections.Generic;

class QuadronacciRectangle
{
    static void Main()
    {
        List<long> tempValues = new List<long>(4);
        for (int i = 0; i < 4; i++)
        {
            tempValues.Add(int.Parse(Console.ReadLine()));
        }        
        tempValues.Reverse();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                if (row == 0)
                {
                    switch (col)
                    {
                        case 0:
                            Console.Write(tempValues[3] + " ");
                            break;
                        case 1:
                            Console.Write(tempValues[2] + " ");
                            break;
                        case 2:
                            Console.Write(tempValues[1] + " ");
                            break;
                        case 3:
                            Console.Write(tempValues[0] + " ");
                            break;
                        default: Console.Write(GetNextItem(tempValues) + " ");
                            break;
                    }
                }
                else
                {
                    Console.Write(GetNextItem(tempValues) + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static long GetNextItem(List<long> tempValues)
    {
        long result = tempValues[0] + tempValues[1] + tempValues[2] + tempValues[3];
        tempValues.Insert(0, result);
        return result;
    }
}