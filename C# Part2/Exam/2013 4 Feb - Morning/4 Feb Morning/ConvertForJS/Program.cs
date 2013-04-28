using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ConvertForJS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test = new List<string>();
            string line;
            line = Console.ReadLine();
            while (line != "")
            {
                test.Add(line);
                line = Console.ReadLine();
            }
            StreamWriter writer;
            if (true)
            {
                int a = 5;
            }
            int a = 10;
            using (writer = new StreamWriter("C:\\Users\\Pavel\\Desktop\\Test.txt",false,Encoding.UTF8))
            {
                foreach (var item in test)
                {
                    writer.WriteLine("'"+item+"',");
                }
            }
        }
    }
}