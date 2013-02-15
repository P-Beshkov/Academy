using System;

class WeAllLoveBits
{
    static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        int i, newNumber,n,copyOfN,j;
        for (i = 1; i <= numbers; i++)
        {
            n = int.Parse(Console.ReadLine());            
            int secondCopyOfN = n;
            copyOfN = n;
            j = 0;
            int[] bits = new int[31];
            do
            {
                if (copyOfN % 2 == 1)
                    bits[j] = 1;
                copyOfN /= 2;
                j++;
            }
            while (copyOfN != 0);
            int[] reversedBits = new int[j];
            Array.Copy(bits, reversedBits, j);
            Array.Reverse(reversedBits);
            for (int p = 0; p < j; p++)
                if (reversedBits[p] == 1) 
                    copyOfN += (int)Math.Pow(2, p);
            newNumber = (n ^ (~secondCopyOfN)) & copyOfN;
            Console.WriteLine(newNumber);
        }
    }
}