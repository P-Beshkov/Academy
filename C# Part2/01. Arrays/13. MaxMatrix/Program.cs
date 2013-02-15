//13. Да се напише програма, която създава правоъгълна матрица с размер 
//n на m. Размерността и елементите на матрицата да се четат от 
//конзолата. Да се намери подматрицата с размер (3,3), която има максимална сума. 
using System;

class Program
{
    static void Main()
    {
        Console.Write("Колони на масива = ");
        int columns = int.Parse(Console.ReadLine());
        Console.Write("Редове на масива = ");
        int rows = int.Parse(Console.ReadLine());
        int[,] arr = new int[rows, columns];
        int currentSum = 0, maxSum = 0;
        int indexR = 0, indexC = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("[{0},{1}] = ", i + 1, j + 1);
                arr[i, j] = int.Parse(Console.ReadLine());

            }
        }
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < columns - 2; j++)
            {
                currentSum = arr[i, j] + arr[i, j + 1] + arr[i, j + 2];
                currentSum += arr[i + 1, j] + arr[i + 1, j + 1] + arr[i + 1, j + 2];
                currentSum += arr[i + 2, j] + arr[i + 2, j + 1] + arr[i + 2, j + 2];
                if (currentSum > maxSum)
                {
                    currentSum = maxSum;
                    indexC = j;
                    indexR = i;
                }
            }
        }
        Console.WriteLine("{0} {1} {2}", arr[indexR, indexC], arr[indexR, indexC + 1], arr[indexR, indexC + 2]);
        Console.WriteLine("{0} {1} {2}", arr[indexR + 1, indexC], arr[indexR + 1, indexC + 1], arr[indexR + 1, indexC + 2]);
        Console.WriteLine("{0} {1} {2}", arr[indexR + 2, indexC], arr[indexR + 2, indexC + 1], arr[indexR + 2, indexC + 2]);
    }
}

