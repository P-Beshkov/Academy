//05. Write a program that reads a text file containing a square matrix of 
//numbers and finds in the matrix an area of size 2 x 2 with a maximal sum 
//of its elements. The first line in the input file contains the size of 
//matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4   ->	17
//3 7 1 2
//4 3 3 2
using System;
using System.IO;

class ReadSquareMatrixFromFile
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\matrix.txt");
        int matrixSize = int.Parse(reader.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];

        for (int row = 0; row < matrixSize; row++)
        {
            string line = reader.ReadLine();
            string tempDigits = string.Empty;
            int column = 0;
            foreach (char item in line)
            {
                if (char.IsDigit(item))
                {
                    tempDigits += item;
                }
                else
                {
                    matrix[row,column++] = int.Parse(tempDigits);
                    tempDigits = string.Empty;
                }
            }
            matrix[row, column++] = int.Parse(tempDigits);
            tempDigits = string.Empty;
        }
        reader.Close();
        Console.WriteLine("Max sum = {0}",MaxArea(matrix));
    }
  
    private static int MaxArea(int[,] matrix)
    {
        int currentSum = 0,
        maxSum = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int column = 0; column < matrix.GetLength(1) - 1; column++)
            {
                currentSum = matrix[row, column] + matrix[row, column + 1];
                currentSum += matrix[row + 1, column] + matrix[row + 1, column + 1];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;                    
                }
                currentSum = 0;
            }
        }
        return maxSum;
    }
}       
//for (int row = 0; row < matrixSize; row++)
//{
//    for (int column = 0; column < matrixSize; column++)
//    {
//        Console.Write(matrix[row,column]+" ");
//    }
//    Console.WriteLine();
//}