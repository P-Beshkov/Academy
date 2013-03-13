/*05. Define a class BitArray64 to hold 64 bit values inside
* an ulong value. Implement IEnumerable<int> and Equals(…), 
* GetHashCode(), [], == and !=. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitArray64
{
    private bool[] isBitOne;
    public ulong value;

    public override int GetHashCode()
    {
        ulong pow = 1;
        ulong code = 0;
        for (int i = 0; i < 64; i++)
        {
            if (this.isBitOne[i])
            {
                code += pow;
            }
            pow *= 2;
        }
        return (int)code;
    }

    public BitArray64()
    {
        isBitOne = new bool[64];
        for (int i = 0; i < 64; i++)
        {
            isBitOne[i] = false;
        }
    }

    public BitArray64(ulong value)
    {
        isBitOne = new bool[64];
        this.value = value;
        int index = 0;
        do
        {
            if (value % 2 == 0)
            {
                isBitOne[index] = true;
            }
            index++;
            value /= 2;
        }
        while (value != 0);
    }

    public override bool Equals(object obj)
    {
        BitArray64 cur = (BitArray64)obj;
        return this.value == cur.value;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 63; i>=0; i--)
        {
            int bit = this.isBitOne[i] ? 1 : 0;
            yield return bit;
        }
    }

    public static bool operator ==(BitArray64 left, BitArray64 right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(BitArray64 left, BitArray64 right)
    {
        return !left.Equals(right);
    }

    public override string ToString()
    {
        StringBuilder temp = new StringBuilder(64);
        for (int i = 63; i >= 0; i--)
        {
            if (this.isBitOne[i])
            {
                temp.Append(1);
            }
            else
            {
                temp.Append(0);
            }
        }
        return temp.ToString();
    }

    static void Main()
    {
        BitArray64 ba1 = new BitArray64(123123);
        Console.WriteLine(ba1);
        foreach (var item in ba1)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}