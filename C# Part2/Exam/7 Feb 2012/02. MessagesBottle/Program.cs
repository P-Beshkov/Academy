using System;
using System.Collections.Generic;

class Program
{    
    static List<Letter> letters = new List<Letter>();
    class Letter
    {
        char symbol;
        string code;
        public Letter(char symbol,string code)
        {
            Symbol = symbol;
            Code = code;
        }
        public string Code
        {
            get;
            private set;
        }

        public char Symbol
        {
            get;
            private set;
        }
    }
    static void Main()
    {
        string secretMessage = Console.ReadLine();
        string rawLetters = Console.ReadLine();

        string code="";
        char letter=rawLetters[0];
        for (int i = 1; i < rawLetters.Length; i++)
        {
            if (char.IsDigit(rawLetters[i]))
                code += rawLetters[i];
            else
                break;
        }
        for (int i = 1+code.Length; i < rawLetters.Length; i++)
        {
            char symbol = rawLetters[i];
            if (char.IsLetter(symbol))
            {
                letters.Add(new Letter(letter, code));
                letter = symbol;
                code = "";
                continue;
            }
            if (char.IsDigit(symbol))
            {
                code += symbol;
            }
        }
        letters.Add(new Letter(letter, code));
        DecodeMessage(secretMessage,"");
        allCombinaitons.Sort();
        Console.WriteLine(allCombinaitons.Count);
        foreach (string item in allCombinaitons)
        {
            Console.WriteLine(item);
        }
    }
    static List<string> allCombinaitons = new List<string>();
    static string foundMess = "";
    static void DecodeMessage(string message,string found)
    {
        if (message.Length == 0)
        {
            allCombinaitons.Add(found);            
            return;
        }
        foreach (var letter in letters)
        {
            if (message.IndexOf(letter.Code)==0)
            {
                found += letter.Symbol;
                string left = message.Substring(letter.Code.Length);
                DecodeMessage(left,found);
                int indexSymbol = found.LastIndexOf(letter.Symbol);
                found = found.Substring(0,indexSymbol);
            }            
        }        
    }
}