using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static List<string> words = new List<string>();
    static int[] mp;
    static int numbersToCombine;
    static string[] cross;
    static bool ready = false;
    static void MyPermutations(int i, int n)
    {
        if (ready)
        {
            return;
        }
        if (i == (numbersToCombine + 1))
        {
            if (CheckCrossword(mp) == true)
            {
                PrintCross();
                ready = true;
            }
            return;
        }
        for (int p = 1; p <= n; p++)
        {
            mp[i] = p;
            MyPermutations(i + 1, n);
        }
    }
    static bool CheckCrossword(int[] mp)
    {
        cross = new string[numbersToCombine];
        StringBuilder word = new StringBuilder(numbersToCombine);
        for (int i = 0; i < numbersToCombine; i++)
        {
            cross[i] = words[mp[i + 1] - 1];
        }
        for (int column = 0; column < numbersToCombine; column++)
        {
            for (int row = 0; row < numbersToCombine; row++)
            {
                word.Append(cross[row][column]);
            }
            string temp = word.ToString();
            if (words.Contains(temp) == false)
            {
                return false;
            }
            word.Clear();
        }
        return true;
    }
    static void PrintCross()
    {
        foreach (string item in cross)
        {
            Console.WriteLine(item);
        }
    }

    static void Main(string[] args)
    {
        numbersToCombine = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numbersToCombine * 2; i++)
        {
            words.Add(Console.ReadLine());
        }
        words.Sort();
        int numbersCount = 8;
        mp = new int[numbersCount + 1];
        MyPermutations(1, numbersCount);
        if (ready == false)
        {
            Console.WriteLine("NO SOLUTION!");
        }
    }
}