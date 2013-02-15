using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { 
        string line = Console.ReadLine();
        string[] rawLikes = line.Split(',', ' ');
        List<int> likes = new List<int>();
        for (int j = 0; j < rawLikes.Length; j++)
        {
            if (rawLikes[j] == "")
                continue;
            likes.Add(int.Parse(rawLikes[j]));
        }
        int wantedMargin = int.Parse(Console.ReadLine());        
        int minLiked = 0, maxLiked = 0;
        if (likes.Count == 1)
        {
            Console.WriteLine(1);
            return;
        }
        int oneTwo = Math.Abs(likes[0] - likes[1]),
        twoThree = Math.Abs(likes[1] - likes[2]),
        oneThree = Math.Abs(likes[0] - likes[2]);
        int i = 0;

        if (oneTwo > oneThree && oneTwo > twoThree)
        {
            maxLiked = Math.Max(likes[0], likes[1]);
            minLiked = Math.Min(likes[0], likes[1]);
            i = 1;
        }
        if (twoThree >= oneThree && twoThree >= oneTwo)
        {
            maxLiked = Math.Max(likes[1], likes[2]);
            minLiked = Math.Min(likes[1], likes[2]);
            i = 2;
        }
        if (oneThree >= oneTwo && oneThree >= twoThree)
        {
            maxLiked = Math.Max(likes[0], likes[2]);
            minLiked = Math.Min(likes[0], likes[2]);
            i = 2;
        }
        int numberOfProblems = 2;
        if (maxLiked - minLiked >= wantedMargin)
        {
            i = likes.Count;
        }
        for (; i < likes.Count - 2;)
        {
            int margin1,
            margin2;
            margin1 = GetMargin(minLiked, maxLiked, likes[i + 1]);
            margin2 = GetMargin(minLiked, maxLiked, likes[i + 2]);
            if (margin2 >= margin1)
            {
                if (likes[i + 2] < minLiked)
                {
                    minLiked = likes[i + 2];
                }
                if (likes[i + 2] > maxLiked)
                {
                    maxLiked = likes[i + 2];
                }
                i += 2;
            }
            else
            {
                if (likes[i + 1] < minLiked)
                {
                    minLiked = likes[i + 1];
                }
                if (likes[i + 1] > maxLiked)
                {
                    maxLiked = likes[i + 1];
                }
                i++;
            }
            numberOfProblems++;
            if (maxLiked - minLiked >= wantedMargin)
            {
                break;
            }
        }
        Console.WriteLine(numberOfProblems);
    }

    private static int GetMargin(int minLiked, int maxLiked, int p)
    {
        if (p >= minLiked && p <= maxLiked)
        {
            return 0;
        }
        if (p < minLiked)
        {
            return maxLiked - p;
        }
        if (p > maxLiked)
        {
            return p - minLiked;
        }
        return 0;
    }
}