using System;
using System.Collections.Generic;

class Program
{
    static List<string> source = new List<string>();

    static int V = 0, W = 0, X = 0, Y = 3, Z = 0;
    public enum Operations
    {
        Equal,
        Bigger,
        Smaller,
        Minus,
        Plus
    }
    static void Main()
    {
        string value = string.Empty;
        do
        {
            value = Console.ReadLine();
            source.Add(value+"\n");
            
        } while (value != "RUN");
        source.RemoveAt(source.Count - 1);
        for (int index = 0; index < source.Count; index++)
        {
            string line = source[index];
            line = line.Trim(' ');
            if (line.IndexOf("IF") != -1)
            {
                int result = ExecuteIF(line);
                if (result != -1)
                {
                    int newIndex = GetIndexOfRow(result);
                    index = newIndex - 1;
                    continue;
                }
                continue;
            }
            if (line.IndexOf("GOTO") != -1)
            {
                int result = GetGotoLine(line);
                int newIndex = GetIndexOfRow(result);
                index = newIndex - 1;
                continue;
            }
            if (line.IndexOf("CLS") != -1)
            {
                Console.Clear();
                continue;
            }
            if (line.IndexOf("PRINT") != -1)
            {
                ExecutePrint(line);
                continue;
            }
            if (line.IndexOf("STOP") != -1)
            {
                break;
            }
            ExecuteCommand(line);
        }        
    }

    private static void ExecutePrint(string line)
    {        
        int index = line.IndexOf("PRINT");
        index += 5;
        char symbol;
        string rawNumber = string.Empty;
        for (int i = index; i < line.Length; i++)
        {
            symbol = line[i];            
            if (char.IsLetter(symbol))
            {
                switch (symbol)
                {
                    case 'V': Console.WriteLine(V);
                        break;
                    case 'W': Console.WriteLine(W);
                        break;
                    case 'X': Console.WriteLine(X);
                        break;
                    case 'Y': Console.WriteLine(Y);
                        break;
                    case 'Z': Console.WriteLine(Z);
                        break;
                }
                return;
            }
        }       
    }

    private static int GetIndexOfRow(int row)
    {
        string rawData, line;
        for (int i = 0; i < source.Count; i++)
        {
            line = source[i];
            rawData = "";
            foreach (char item in line)
            {
                if (item>='0' && item <='9')
                {
                    rawData += item;
                }
            }
            int number = int.Parse(rawData);
            if (number == row)
            {
                return i;
            }
        }
        return 0;
    }

    private static int GetGotoLine(string line)
    {
        int index = line.IndexOf("GOTO");
        index += 4;
        char symbol;
        string rawNumber = "";
        for (int i = index; i < line.Length; i++)
        {
            symbol = line[i];
            if (char.IsDigit(symbol))
            {
                rawNumber += symbol;
            }
        }
        int number = int.Parse(rawNumber);
        return number;
    }

    private static int ExecuteIF(string line)
    {
        Operations operattion = Operations.Equal;
        int leftOperand = 0,
            rightOperand = 0;
        int index = line.IndexOf("IF");
        index += 2;
        string rawNumber = "";
        int i;
        for (i = index; i < line.Length; i++)
        {
            char symbol = line[i];
            if (char.IsDigit(symbol) || symbol == '-')
            {
                rawNumber += symbol;
            }
            if (symbol >= 86 && symbol <= 90)
            {
                switch (symbol)
                {
                    case 'V': leftOperand = V;
                        break;
                    case 'W': leftOperand = W;
                        break;
                    case 'X': leftOperand = X;
                        break;
                    case 'Y': leftOperand = Y;
                        break;
                    case 'Z': leftOperand = Z;
                        break;
                    default:
                        break;
                }
                break;
            }
            if (rawNumber !="" && !char.IsDigit(symbol))
            {
                leftOperand = int.Parse(rawNumber);
                break;
            }
        }
        for (; i < line.Length; i++)
        {
            char symbol = line[i];
            if (symbol == '<')
            {
                operattion = Operations.Smaller;
                break;
            }
            if (symbol == '>')
            {
                operattion = Operations.Bigger;
                break;
            }
            if (symbol == '=')
            {
                operattion = Operations.Equal;
                break;
            }
        }
        rawNumber = "";
        for (i++; i < line.Length; i++)
        {
            char symbol = line[i];
            if (char.IsDigit(symbol) || symbol == '-')
            {
                rawNumber += symbol;
                continue;
            }
            if (symbol >= 86 && symbol <= 90)
            {
                switch (symbol)
                {
                    case 'V': rightOperand = V;
                        break;
                    case 'W': rightOperand = W;
                        break;
                    case 'X': rightOperand = X;
                        break;
                    case 'Y': rightOperand = Y;
                        break;
                    case 'Z': rightOperand = Z;
                        break;
                    default:
                        break;
                }
                break;
            }
            if (rawNumber != "" && !char.IsDigit(symbol))
            {
                rightOperand = int.Parse(rawNumber);
                break;
            }
        }
        bool result = false;
        switch (operattion)
        {
            case Operations.Equal: result = leftOperand == rightOperand;
                break;
            case Operations.Bigger: result = leftOperand > rightOperand;
                break;
            case Operations.Smaller: result = leftOperand < rightOperand;
                break;
        }
        if (result)
        {
            index = line.IndexOf("THEN");
            index += 4;
            string command = line.Substring(index);
            if (command.IndexOf("GOTO") != -1)
            {
                int value = GetGotoLine(command);
                return value;
            }
            ExecuteCommand(command);

        }
        return -1;
    }
    static void ExecuteCommand(string command)
    {
        command = command.Trim();
        string right = command.Substring(command.IndexOf("=") + 1);
        int firstStart = right.IndexOfAny(new char[] { '-', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
        int firstPart = 0,            secondPart = 0;
        char firstSymbol = right[firstStart];
        bool firstMinus = right[firstStart] == '-';
        int rightResult = 0;
        int leftStart;
        if (firstMinus)
        {
            firstStart++;
        }
        firstSymbol = right[firstStart];
        if (char.IsDigit(firstSymbol))
        {
            string rawFirst = "";
            for (int i = firstStart; i < right.Length; i++)
            {
                if (char.IsDigit(right[i]))
                {
                    rawFirst += right[i];
                }
                else
                {
                    break;
                }
            }
            firstPart = int.Parse(rawFirst);
        }
        if (char.IsLetter(firstSymbol))
        {
            switch (firstSymbol)
            {
                case 'V': firstPart = V;
                    break;
                case 'W': firstPart = W;
                    break;
                case 'X': firstPart = X;
                    break;
                case 'Y': firstPart = Y;
                    break;
                case 'Z': firstPart = Z;
                    break;
                default: Console.WriteLine("Encounter Error!");
                    break;
            }
        }
        if (firstMinus)
        {
            firstPart *= -1;
        }

        int operationIndex = right.IndexOfAny(new char[] { '+', '-' }, firstStart);
        if (operationIndex == -1)
        {
            rightResult = firstPart;
            leftStart = command.IndexOfAny(new char[] { 'V', 'W', 'X', 'Y', 'Z' });
            switch (command[leftStart])
            {
                case 'V': V = rightResult;
                    break;
                case 'W': W = rightResult;
                    break;
                case 'X': X = rightResult;
                    break;
                case 'Y': Y = rightResult;
                    break;
                case 'Z': Z = rightResult;
                    break;
                default: Console.WriteLine("Encounter Error!");
                    break;
            }

        }
        else
        {
            char rawOperation = right[operationIndex];
            Operations action;
            if (rawOperation == '+')
            {
                action = Operations.Plus;
            }
            else
            {
                action = Operations.Minus;
            }
            int secondStart = right.IndexOfAny(new char[] { '-', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, operationIndex + 1);
            char secondSymbol = right[secondStart];
            if (char.IsDigit(secondSymbol))
            {
                string rawSecond = "";
                for (int i = secondStart; i < right.Length; i++)
                {
                    if (char.IsDigit(right[i]))
                    {
                        rawSecond += right[i];
                    }
                    else
                    {
                        break;
                    }
                }
                secondPart = int.Parse(rawSecond);
            }
            if (char.IsLetter(secondSymbol))
            {
                switch (secondSymbol)
                {
                    case 'V': secondPart = V;
                        break;
                    case 'W': secondPart = W;
                        break;
                    case 'X': secondPart = X;
                        break;
                    case 'Y': secondPart = Y;
                        break;
                    case 'Z': secondPart = Z;
                        break;
                    default: Console.WriteLine("Encounter Error!");
                        break;
                }
            }
            switch (action)
            {
                case Operations.Minus: rightResult = firstPart - secondPart;
                    break;
                case Operations.Plus: rightResult = firstPart + secondPart;
                    break;
            }
        }

        leftStart = command.IndexOfAny(new char[] { 'V', 'W', 'X', 'Y', 'Z' });
        switch (command[leftStart])
        {
            case 'V': V = rightResult;
                break;
            case 'W': W = rightResult;
                break;
            case 'X': X = rightResult;
                break;
            case 'Y': Y = rightResult;
                break;
            case 'Z': Z = rightResult;
                break;
            default: Console.WriteLine("Encounter Error!");
                break;
        }
    }
}