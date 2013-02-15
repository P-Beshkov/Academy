//07.* Write a program that finds the largest area of equal neighbor 
//elements in a rectangular matrix and prints its size. Example:

using System;

class LargestArea
{
    static private int[,] matrix = 
    {
        { 1, 3, 2, 2, 2, 3 },
        { 3, 3, 3, 2, 4, 3 },
        { 4, 3, 1, 2, 3, 3 },
        { 4, 3, 1, 3, 3, 1 },
        { 4, 3, 3, 3, 1, 1 },
    };
    static private int[,] largestFound = new int[matrix.GetLength(0), matrix.GetLength(1)];
    //with "1" is marked the path 
    static void FindArea(int row, int column, int previousValue)
    {

        if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1) || row < 0 || column < 0 || largestFound[row, column] > 0)
        {
            return;
        }
        if (previousValue != matrix[row, column])
        {
            largestFound[row, column] = 2;
            return;
        }
        else
        {
            largestFound[row, column] = 1;
        }

        largestFound[row, column] = 1;
        FindArea(row - 1, column, matrix[row, column]);//up
        FindArea(row, column + 1, matrix[row, column]);//right
        FindArea(row + 1, column, matrix[row, column]);//down
        FindArea(row, column - 1, matrix[row, column]);//right

    }

    static private void printArea()
    {
        for (int row = 0; row < largestFound.GetLength(0); row++)
        {
            for (int column = 0; column < largestFound.GetLength(1); column++)
            {
                if (largestFound[row, column] == 1)
                {
                    Console.Write("{0,3}", largestFound[row, column]);
                }
                else
                {
                    Console.Write("  0");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        FindArea(1, 0, matrix[0, 1]);
        printArea();
    }
}