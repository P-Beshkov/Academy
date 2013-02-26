using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static Dictionary<string, int> states = new Dictionary<string, int>()
    {
        { "1111110", 126 }, //126
        { "0110000", 48 }, //48
        { "1101101", 109 }, //109
        { "1111001", 121 }, //121
        { "0110011", 51 }, //51
        { "1011011", 91 }, //91
        { "1011111", 95 }, //95
        { "1110000", 112 }, //112
        { "1111111", 127 }, //127
        { "1111011", 123 }, //123
    };
    static private int ConvertAnyToDecimal(string number, int inputBase)
    {
        int result = 0;
        int pow = 1;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int value;
            value = ExtractValue(number[i]);
            result += value * pow;
            pow *= inputBase;
        }

        return result;
    }
    static private int ExtractValue(char symbol)
    {
        if (symbol >= 'A')
        {
            return symbol - 'A' + 10;
        }
        else
        {
            return symbol - '0';
        }
    }
    static int digitsCount = int.Parse(Console.ReadLine());
    static DigitState[] digits = new DigitState[digitsCount];
    static int combinationsFound = 0;
    class DigitState
    {
        public List<int> posibleStates;

        private struct Segment
        {
            public int value;
            public string state;
        }
        public DigitState(string defaultState)
        {
            posibleStates = new List<int>();
            int defaultMask = ConvertAnyToDecimal(defaultState, 2);
            int value = 0;
            foreach (var item in states)
            {
                if ((defaultMask & item.Value) == defaultMask)
                {
                    posibleStates.Add(value);
                }
                value++;
            }
            //posibleStates.Sort();
        }
    }
    static void Main()
    {
        

        for (int i = 0; i < digitsCount; i++)
        {
            digits[i] = new DigitState(Console.ReadLine());
        }
        GenComb(0);
        Console.WriteLine(combinationsFound);
        Console.Write(result.ToString());
    }
    static StringBuilder result = new StringBuilder();
    public static void GenComb(int curPosisiton)
    {
        if (curPosisiton==digitsCount)
        {
            combinationsFound++;
            result.Append('\n');
            return;
        }

        for (int i = 0; i < digits[curPosisiton].posibleStates.Count; i++)
        {
            result.Append(digits[curPosisiton].posibleStates[i]);
            GenComb(curPosisiton + 1);
        }
    }
}