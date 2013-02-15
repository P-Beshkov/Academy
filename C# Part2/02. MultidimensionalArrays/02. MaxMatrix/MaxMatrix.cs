//02. Write a program that reads a rectangular matrix of size N x M and 
//finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Columns = ");
        int columns = int.Parse(Console.ReadLine());
        Console.Write("Rows = ");
        int rows = int.Parse(Console.ReadLine());
        int[,] arr = new int[rows, columns];
        int currentSum = 0, maxSum = 0;
        int indexR = 0, indexC = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.Write("[{0},{1}] = ", row, column);
                arr[row, column] = int.Parse(Console.ReadLine());

            }
        }
        for (int row = 0; row < rows - 2; row++)
        {
            for (int column = 0; column < columns - 2; column++)
            {
                currentSum = arr[row, column] + arr[row, column + 1] + arr[row, column + 2];
                currentSum += arr[row + 1, column] + arr[row + 1, column + 1] + arr[row + 1, column + 2];
                currentSum += arr[row + 2, column] + arr[row + 2, column + 1] + arr[row + 2, column + 2];
                if (currentSum > maxSum)
                {
                    maxSum=currentSum;
                    indexC = column;
                    indexR = row;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", arr[indexR, indexC], arr[indexR, indexC + 1], arr[indexR, indexC + 2]);
        Console.WriteLine("{0} {1} {2}", arr[indexR + 1, indexC], arr[indexR + 1, indexC + 1], arr[indexR + 1, indexC + 2]);
        Console.WriteLine("{0} {1} {2}", arr[indexR + 2, indexC], arr[indexR + 2, indexC + 1], arr[indexR + 2, indexC + 2]);
    }
}

