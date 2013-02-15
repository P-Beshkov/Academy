//10. Write a program that extracts from given XML file all the text without the tags. 
//Example: <?xml version="1.0"><student><name>Pesho</name><age>21</age>
//<interests count="3"><interest> Games</instrest><interest>C#</instrest>
//<interest> Java</instrest></interests></student>

using System;
using System.IO;

class ExtractFromXML
{
    static void Main()
    {
        StreamReader reader;
        using (reader=new StreamReader("..\\..\\XMLFile.xml"))
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\TextOnly.txt"))
            {
                string line;
                bool inTag = false;
                line = reader.ReadLine();
                while (line != null)
                {
                    foreach (char item in line)
                    {
                        if (item == '<' && inTag == false)
                        {
                            inTag = true;
                        }
                        if (item == '>' && inTag == true)
                        {
                            inTag = false;
                            continue;
                        }
                        if (inTag == false)
                        {
                            writer.Write(item);
                        }
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}