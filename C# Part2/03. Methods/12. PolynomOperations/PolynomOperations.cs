//12. Extend the program to support also subtraction and multiplication of polynomials.

using System;
using System.Collections.Generic;

class PolynomOperations
{
    public class Polynom
    {
        private List<decimal> coefficient;
        private int level;

        public decimal this[int index]
        {
            get
            {
                if (index >= coefficient.Count)
                {
                    coefficient.Add(0);

                }
                return this.coefficient[index];
            }
            set
            {
                if (index >= coefficient.Count)
                {
                    coefficient.Add(0);

                }
                coefficient[index] = value;
            }
        }        
        public int Level
        {
            get
            {
                return this.coefficient.Count;
            }
        }

        public Polynom(params decimal[] coeff)
        {
            level = coeff.Length;
            coefficient = new List<decimal>();
            foreach (decimal item in coeff)
            {
                this.coefficient.Add(item);

            }
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.Level; i++)
            {
                result += "(" + this.coefficient[i] + "*x^" + (this.Level - i) + ")*";
            }
            return result.Substring(0, result.Length - 1);
        }
        static public Polynom operator +(Polynom firstAddend, Polynom secondAddend)
        {
            int biggerLenght = firstAddend.Level > secondAddend.Level ? firstAddend.Level : secondAddend.Level;
            int smallerLenght = firstAddend.Level > secondAddend.Level ? secondAddend.Level : firstAddend.Level;
            Polynom result = new Polynom();
            for (int i = 0; i < smallerLenght; i++)
            {
                result[i] = firstAddend[i] + secondAddend[i];
            }
            Polynom biggerAddend = firstAddend.Level > secondAddend.Level ? firstAddend : secondAddend;
            for (int i = smallerLenght; i < biggerLenght; i++)
            {
                result[i] = biggerAddend[i];
            }
            return result;
        }
        static public Polynom operator -(Polynom firstAddend, Polynom secondAddend)
        {
            int biggerLenght = firstAddend.Level > secondAddend.Level ? firstAddend.Level : secondAddend.Level;
            int smallerLenght = firstAddend.Level > secondAddend.Level ? secondAddend.Level : firstAddend.Level;
            Polynom result = new Polynom();
            for (int i = 0; i < smallerLenght; i++)
            {
                result[i] = firstAddend[i] - secondAddend[i];
            }
            Polynom biggerAddend = firstAddend.Level > secondAddend.Level ? firstAddend : secondAddend;
            for (int i = smallerLenght; i < biggerLenght; i++)
            {
                result[i] = biggerAddend[i];
            }
            return result;
        }
        static public Polynom operator* (Polynom firstMultiply, Polynom secondMultiply)
        {
            Polynom result = new Polynom();
            
            for (int i = 0; i < firstMultiply.Level; i++)
            {
                for (int j = 0; j < secondMultiply.Level; j++)
                {
                    int position = i + j;
                    result[position] += (firstMultiply[i] * secondMultiply[j]);
                }
            }
            return result;
        }
    }
    static void Main()
    {
        Polynom first = new Polynom(5, 0, 2, 5);
        Polynom second = new Polynom(4, 0, 3);
        Polynom result = first * second;
        Console.WriteLine(result.ToString());
    }
}