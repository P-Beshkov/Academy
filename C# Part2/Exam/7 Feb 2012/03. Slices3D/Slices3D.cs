using System;
using System.Collections.Generic;
using System.Text;

class Slices3D
{
    static void Main()
    {
        string rawDim = Console.ReadLine();
        string[] dimensions = rawDim.Split(' ');
        int width = int.Parse(dimensions[0]);
        int height = int.Parse(dimensions[1]);
        int deepth = int.Parse(dimensions[2]);
        int[,,] cube = new int[width,height,deepth];
        int cutsCount = 0;
        long totalSum = 0;
        for (int h = 0; h < height; h++)
        {
            string inputLine = Console.ReadLine();
            string[] floor = inputLine.Split('|');
            for (int d = 0; d < deepth; d++)
            {
                string[] rowValues = floor[d].Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
                for (int w = 0; w < width; w++)
                {
                    int value = int.Parse(rowValues[w]);
                    cube[w, h, d] = value;
                    totalSum += value;
                }
            }            
        }
        long halfSum = 0;
        for (int h = 0; h < height-1; h++)
        {            
            for (int d = 0; d < deepth; d++)
            {                
                for (int w = 0; w < width; w++)
                {
                    halfSum+=cube[w,h,d];
                }                
            }
            if ((halfSum <<1) == totalSum)
            {
                cutsCount++;
            }
        }
        halfSum = 0;
        for (int d = 0; d < deepth - 1; d++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    halfSum += cube[w, h, d];
                }
            }
            if ((halfSum << 1) == totalSum)
            {
                cutsCount++;
            }
        }
        halfSum = 0;
        for (int w = 0; w < width - 1; w++)
        {
            for (int d = 0; d < deepth; d++)
            {
                for (int h = 0; h < height; h++)
                {
                    halfSum += cube[w, h, d];
                }
            }
            if ((halfSum << 1) == totalSum)
            {
                cutsCount++;
            }
        }
        Console.WriteLine(cutsCount);
    }
}