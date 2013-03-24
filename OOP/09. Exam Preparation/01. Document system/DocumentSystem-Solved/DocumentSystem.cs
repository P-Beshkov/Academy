using System;
using System.Collections.Generic;

public class DocumentSystem
{
    /*На функциите за добавяне на нов документ, късно се усетих че трябва
     * да се зареждат от конкретния клас и не ми остана време, но поне си
     * видях грешката :) 
     * ПС. 92 точки дава в BGCoder */
    public static List<Document> documents = new List<Document>();   
    public static List<string> output = new List<string>();

    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
        foreach (var item in output)
        {
            Console.WriteLine(item);
        }
    }

    private static IList<string> ReadAllCommands()
    {
        List<string> commands = new List<string>();
        while (true)
        {
            string commandLine = Console.ReadLine();
            if (commandLine == "")
            {
                // End of commands
                break;
            }
            commands.Add(commandLine);
        }
        return commands;
    }

    private static void ExecuteCommands(IList<string> commands)
    {
        foreach (var commandLine in commands)
        {
            int paramsStartIndex = commandLine.IndexOf("[");
            string cmd = commandLine.Substring(0, paramsStartIndex);
            int paramsEndIndex = commandLine.IndexOf("]");
            string parameters = commandLine.Substring(
                paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
            ExecuteCommand(cmd, parameters);
        }
    }

    private static void ExecuteCommand(string cmd, string parameters)
    {
        string[] cmdAttributes = parameters.Split(
            new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        if (cmd == "AddTextDocument")
        {
            AddTextDocument(cmdAttributes);
        }
        else if (cmd == "AddPDFDocument")
        {
            AddPdfDocument(cmdAttributes);
        }
        else if (cmd == "AddWordDocument")
        {
            AddWordDocument(cmdAttributes);
        }
        else if (cmd == "AddExcelDocument")
        {
            AddExcelDocument(cmdAttributes);
        }
        else if (cmd == "AddAudioDocument")
        {
            AddAudioDocument(cmdAttributes);
        }
        else if (cmd == "AddVideoDocument")
        {
            AddVideoDocument(cmdAttributes);
        }
        else if (cmd == "ListDocuments")
        {
            ListDocuments();
        }
        else if (cmd == "EncryptDocument")
        {
            EncryptDocument(parameters);
        }
        else if (cmd == "DecryptDocument")
        {
            DecryptDocument(parameters);
        }
        else if (cmd == "EncryptAllDocuments")
        {
            EncryptAllDocuments();
        }
        else if (cmd == "ChangeContent")
        {
            ChangeContent(cmdAttributes[0], cmdAttributes[1]);
        }
        else
        {
            throw new InvalidOperationException("Invalid command: " + cmd);
        }
    }

    private static void AddTextDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        Text newDoc = new Text("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "charset")
            {
                newDoc.CharSet = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
        }
        documents.Add(newDoc);
        output.Add("Document added: " + newDoc.Name);
    }

    private static void AddPdfDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        PDF newDoc = new PDF("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
            else if (attribute == "size")
            {
                newDoc.Size = long.Parse(value);
            }
            else if (attribute == "pages")
            {
                newDoc.PagesCount = int.Parse(value);
            }
        }
        documents.Add(newDoc);
        output.Add("Document added: " + newDoc.Name);
    }

    private static void AddWordDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        Word newDoc = new Word("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
            else if (attribute == "size")
            {
                newDoc.Size = long.Parse(value);
            }
            else if (attribute == "version")
            {
                newDoc.Version = value;
            }
            else if (attribute == "chars")
            {
                newDoc.CharsCount = long.Parse(value);
            }
        }
        documents.Add(newDoc);        
        output.Add("Document added: " + newDoc.Name);
    }

    private static void AddExcelDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        Excel newDoc = new Excel("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
            else if (attribute == "size")
            {
                newDoc.Size = long.Parse(value);
            }
            else if (attribute == "version")
            {
                newDoc.Version = value;
            }
            else if (attribute == "rows")
            {
                newDoc.RowsCount = int.Parse(value);
            }
            else if (attribute == "cols")
            {
                newDoc.ColsCount = int.Parse(value);
            }
        }
        documents.Add(newDoc);        
        output.Add("Document added: " + newDoc.Name);
    }

    private static void AddAudioDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        Audio newDoc = new Audio("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
            else if (attribute == "size")
            {
                newDoc.Size = long.Parse(value);
            }
            else if (attribute == "length")
            {
                newDoc.Lenght = int.Parse(value);
            }
            else if (attribute == "samplerate")
            {
                newDoc.SampleRate = int.Parse(value);
            }
        }
        documents.Add(newDoc);
        output.Add("Document added: " + newDoc.Name);
    }

    private static void AddVideoDocument(string[] attributes)
    {
        bool hasName = false;
        foreach (string item in attributes)
        {
            if (item.StartsWith("name"))
            {
                hasName = true;
            }
        }
        if (hasName == false)
        {
            output.Add("Document has no name");
            return;
        }
        Video newDoc = new Video("Indicial");
        foreach (string item in attributes)
        {
            string attribute = item.Substring(0, item.IndexOf('='));
            string value = item.Substring(item.IndexOf('=') + 1);
            if (attribute == "name")
            {
                newDoc.Name = value;
            }
            else if (attribute == "content")
            {
                newDoc.Content = value;
            }
            else if (attribute == "size")
            {
                newDoc.Size = long.Parse(value);
            }
            else if (attribute == "length")
            {
                newDoc.Lenght = int.Parse(value);
            }
            else if (attribute == "framerate")
            {
                newDoc.FrameRate = int.Parse(value);
            }
        }
        documents.Add(newDoc);
        output.Add("Document added: " + newDoc.Name);
    }

    private static void ListDocuments()
    {
        foreach (var item in documents)
        {
            output.Add(item.ToString());
        }
    }

    private static void EncryptDocument(string name)
    {
        bool foundOne = false;
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Name == name)
            {
                if (documents[i] is IEncryptable)
                {
                    foundOne = true;
                    documents[i].LoadProperty("IsEncrypted", "true");
                    output.Add("Document encrypted: " + documents[i].Name);
                }
                else
                {
                    foundOne = true;
                    output.Add("Document does not support encryption: " + documents[i].Name);
                }
            }
        }
        if (!foundOne)
        {
            output.Add("Document not found: " + name);
        }
    }

    private static void DecryptDocument(string name)
    {
        bool foundOne = false;
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Name == name)
            {
                if (documents[i] is IEncryptable)
                {
                    foundOne = true;
                    documents[i].LoadProperty("IsEncrypted", "false");
                    output.Add("Document decrypted: " + documents[i].Name);
                }
                else
                {
                    foundOne = true;
                    output.Add("Document does not support decryption: " + documents[i].Name);
                }
            }
        }
        if (!foundOne)
        {
            output.Add("Document not found: " + name);
        }
    }

    private static void EncryptAllDocuments()
    {
        bool foundOne = false;
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i] is IEncryptable)
            {
                foundOne = true;
                documents[i].LoadProperty("IsEncrypted", "true");
            }
        }
        if (foundOne)
        {
            output.Add("All documents encrypted");
        }
        else
        {
            output.Add("No encryptable documents found");
        }
    }

    private static void ChangeContent(string name, string content)
    {
        bool foundOne = false;
        for (int i = 0; i < documents.Count; i++)
        {
            if (documents[i].Name == name)
            {
                if (documents[i] is IEditable)
                {
                    documents[i].Content = content;
                    output.Add("Document content changed: " + documents[i].Name);
                    foundOne = true;
                }
                else
                {
                    output.Add("Document is not editable: " + documents[i].Name);
                    foundOne = true;
                }
            }
        }
        if (!foundOne)
        {
            output.Add("Document not found: " + name);    
        }
    }
}