using System;

class MissCat2011
{
    static void Main()
    {
        byte catNumber = 1;
        int[] catsVotes = new int[11];
        int numberOfJury = int.Parse(Console.ReadLine());
        int i,mostVotes,vote;
        for (i = 1; i <= numberOfJury; i++)
        {
            vote = int.Parse(Console.ReadLine());
            catsVotes[vote]++;
        }
        mostVotes = catsVotes[1];
        for (i = 2; i <= 10; i++)
        {
            if (catsVotes[i] > mostVotes)
            {
                mostVotes = catsVotes[i];
                catNumber = (byte)i;
            }
        }
        Console.WriteLine(catNumber);
    }
}