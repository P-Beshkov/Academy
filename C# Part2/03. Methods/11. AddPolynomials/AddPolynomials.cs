//Write a method that adds two polynomials. Represent them 
//as arrays of their coefficients as in the example below:

using System;
using System.Collections.Generic;

class AddPolynomials
{
    

    public class Polynom
    {
        private List<decimal> coefficient;
        private int level;

        public decimal this[int index]
        {
            get
            {
                return this.coefficient[index];
            }
            set
            {
                if (index>=coefficient.Count)
                {
                    coefficient.Add(0);
                    
                }
                coefficient[index] = value;
            }
        }

        //public Polynom(string raw)
        //{
        //    char[] oprators = {'+','-'};
        //    this.rawValue = raw;
        //    int indexX = raw.IndexOf("x");
        //    int lastLevel = 0;
        //    int indexCoeff = 0;
        //    string value;
        //    if (indexX != 0)
        //    {
        //        value = rawValue.Substring(0, indexX);
        //        coefficients.Add(int.Parse(value));
        //    }
        //    else
        //    {
        //        coefficients.Add(1);                
        //    }
        //    int indexOfNextOpeator = rawValue.IndexOfAny(oprators, indexX + 2);
        //    value = rawValue.Substring(indexX + 2, indexOfNextOpeator - indexX - 2);
        //    lastLevel = int.Parse(value);
        //}
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
        public override string ToString ()
        {
            string result = "";
            for (int i = 0; i < this.Level; i++)
            {
                result += "("+this.coefficient[i] + "*x^" + (this.Level - i)+")*";
            }
            return result.Substring(0,result.Length-1);
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
    }
    static void Main()
    {
        Polynom first = new Polynom(5, 0, 2,5);
        Polynom second = new Polynom(4, 0, 3);
        Polynom result = first + second;
        Console.WriteLine(result.ToString());
    }
}