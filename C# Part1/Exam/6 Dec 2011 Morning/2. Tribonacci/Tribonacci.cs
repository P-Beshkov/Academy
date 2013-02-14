using System;
using System.Numerics;


class Tribonacci
{
    static void Main()
    {
        
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        int allMembers = int.Parse(Console.ReadLine());
        BigInteger newMember = 0;
        int i;
        if (allMembers == 1)
            Console.WriteLine(firstMember);
        else if (allMembers == 2)
            Console.WriteLine(secondMember);
        else if (allMembers == 3)
            Console.WriteLine(thirdMember);
        else
        {
            for (i = 4; i <= allMembers; i++)
            {
                newMember = firstMember + secondMember + thirdMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = newMember;
            }
            Console.WriteLine(newMember);
        }
    }
}