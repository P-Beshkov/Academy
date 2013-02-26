using System;
using System.Collections.Generic;

class PHPVariables
{
    static void Main()
    {
        bool hadEscaping = false,
            notInComment = true,
            inSingleQuote = false,
            inDoubleQuote = false,
            notInQuote = true,
            inSingleLineComment = false,
            inMultiLineComment = false,
            savingVariable = false;
        char lastSymbol='d';
        List<string> variables = new List<string>();
        string tempVar = String.Empty;
        while (true)
        {
            char symbol = (char)Console.Read();
            //Check comments ending
            if (inSingleLineComment && symbol=='\n')
            {
                inSingleLineComment = false;
                notInComment = true;
            }
            if (inMultiLineComment && lastSymbol=='*' && symbol=='/')
            {
                inMultiLineComment = false;
                notInComment = true;
            }
            //Check escaping
            if (hadEscaping)
            {
                hadEscaping = false;
                lastSymbol = symbol;
                continue;
            }
            if (symbol == '\\' && notInComment)
            {
                hadEscaping = true;
                lastSymbol = symbol;
                continue;
            }
            //Check going in quote
            if (symbol=='\'' && notInComment && notInQuote)
            {
                inSingleQuote = true;
                notInQuote = false;
            }
            if (symbol=='"' && notInQuote && notInComment)
            {
                inDoubleQuote = true;
                notInQuote = false;
            }
            //Check going out of quote
            if (inSingleQuote && symbol=='\'')
            {
                inSingleQuote = false;
                notInQuote = true;
            }
            if (inDoubleQuote && symbol=='"')
            {
                inDoubleQuote = false;
                notInQuote = true;
            }
            //Check singleLine comment
            if (notInQuote && symbol=='#' && notInComment)
            {
                notInComment = false;
                inSingleLineComment = true;
            }
            if (notInQuote && symbol == '/'&& lastSymbol=='/' && notInComment)
            {
                notInComment = false;
                inSingleLineComment = true;
            }
            //Check multiline comment
            if (notInQuote && symbol == '*' && lastSymbol == '/' && notInComment)
            {
                notInComment = false;
                inMultiLineComment = true;
            }

            if (symbol=='$' && notInComment && notInQuote)
            {
                savingVariable = true;
                lastSymbol = symbol;
                continue;
            }

            if (savingVariable)
            {
                if (!Char.IsLetterOrDigit(symbol) && symbol!='_')
                {
                    if (!variables.Contains(tempVar))
                    {
                        variables.Add(tempVar);                        
                    }
                    savingVariable = false;
                    tempVar = String.Empty;
                    
                }
                else
                {
                    tempVar += symbol;
                    
                }
            }
            if (lastSymbol=='?' && symbol=='>')
            {
                break;
            }
            lastSymbol = symbol;
            
        }
        variables.Sort();
        Console.WriteLine(variables.Count);
        foreach (string item in variables)
        {
            Console.WriteLine(item);
        }
    }
}