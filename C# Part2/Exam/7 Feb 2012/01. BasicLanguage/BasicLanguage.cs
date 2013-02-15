using System;
using System.Text;

class Program
{
    static StringBuilder result = new StringBuilder();

    static void Main()
    {
        StringBuilder buffer = new StringBuilder();
        bool inBrackets = false;
        while (true)
        {
            char nextChar = (char)Console.Read();
            if (nextChar == '(')
            {
                inBrackets = true;
            }
            if (nextChar == ')')
            {
                inBrackets = false;
            }
            if (nextChar == ';' && !inBrackets)
            {
                string statement = buffer.ToString();
                if (Execute(statement))
                {
                    break;
                }
                buffer.Clear();
            }
            else
            {
                if (inBrackets || !char.IsWhiteSpace(nextChar))
                {
                    buffer.Append(nextChar);
                }
            }
        }
        Console.WriteLine(result.ToString());
    }

    private static bool Execute(string statement)
    {
        long totalCount = 1;
        string[] commands = statement.Split(')');        
        for (int i = 0; i < commands.Length; i++)
        {
            string cmd = commands[i].TrimStart();
            if (cmd.StartsWith("PRINT"))
            {
                int start = cmd.IndexOf('(') + 1;
                string content = cmd.Substring(start);
                StringBuilder buffer = new StringBuilder();
                if (content.Length > 0)
                {
                    for (int c = 0; c < totalCount; c++)
                    {
                        buffer.Append(content);
                    }
                    result.Append(buffer.ToString());
                }
            }
            else if (cmd.StartsWith("FOR"))
            {
                int startIndex = cmd.IndexOf('(') + 1;
                int commaIndex = cmd.IndexOf(',');
                int count;
                if (commaIndex == -1)
                {
                    string rawCount = cmd.Substring(startIndex);
                    count = int.Parse(rawCount);
                    totalCount *= count;
                }
                else
                {
                    string rawCount = cmd.Substring(startIndex, commaIndex - startIndex);
                    int a = int.Parse(rawCount),
                    b = int.Parse(cmd.Substring(commaIndex + 1));
                    count = b - a + 1;
                    totalCount *= count;                    
                }
            }
            else if (cmd.StartsWith("EXIT"))
            {
                return true;
            }
        }
        return false;
    }
}
//static string TrimWhiteSpaces(string command)
//{
//    StringBuilder editedCommand = new StringBuilder();

//    int indexPrint = command.IndexOf("PRINT");
//    for (int i = 0; i < indexPrint; i++)
//    {
//        if (command[i] == ' ')
//        {
//            continue;
//        }
//        else
//        {
//            editedCommand.Append(command[i]);
//        }
//    }
//    return editedCommand.ToString() + command.Substring(indexPrint);
//}
//static int CalculateFor(string command)
//{
//    MatchCollection matches = Regex.Matches(command,@"FOR\((?<a>-?\d+),?(?<b>-?\d+)?\)\s*");
//    int times = 1;
//    foreach (Match match in matches)
//    {
//        string rawA = match.Groups["a"].Value;
//        string rawB = match.Groups["b"].Value;
//        if (match.Groups["b"].Length == 0)
//        {
//            times *= int.Parse(rawA);
//        }
//        else
//        {
//            int a = int.Parse(rawA),
//                b = int.Parse(rawB);
//            times *= b - a + 1;
//        }
//    }
//    return times;
//}

//static void Main()
//{
//    StringBuilder tempSource = new StringBuilder();
//    string line;
//    do
//    {
//        line = Console.ReadLine();
//        if(line!=null)
//            tempSource.Append(line);            
//    }
//    while (line.IndexOf("EXIT") == -1);
//    string source = tempSource.ToString();
//    string[] commands = source.Split(new char[] { ';','\n' }, StringSplitOptions.RemoveEmptyEntries);
//    MatchCollection matches;

//    foreach (string command in commands)
//    {
//        if (command.IndexOf("EXIT") != -1)
//        {
//            Console.WriteLine();
//            return;
//        }
//        bool hasFor = command.IndexOf("FOR") != -1;
//        if (hasFor)
//        {
//            string trimmedCommand = TrimWhiteSpaces(command);
//            int cycles = CalculateFor(trimmedCommand);
//            matches = Regex.Matches(command, @"\s*PRINT\s*\((?<text>[^)]*)\)\s*");
//            string forPrint = matches[0].Groups["text"].Value;
//            StringBuilder temp = new StringBuilder(cycles * forPrint.Length);
//            for (int i = 0; i < cycles; i++)
//            {
//                temp.Append(forPrint);
//            }
//            Console.Write(temp.ToString());
//        }
//        else
//        {
//            matches = Regex.Matches(command, @"\s*PRINT\s*\((?<text>[^)]*)\)\s*");
//            Console.Write(matches[0].Groups["text"]);
//        }
//    }       
//}