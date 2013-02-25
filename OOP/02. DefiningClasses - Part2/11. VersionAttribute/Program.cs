using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    [Version(3,132)]
    class TestClass
    {

    }
    static void Main(string[] args)
    {
        Type type = typeof(TestClass);

        foreach (var atribute in type.GetCustomAttributes(false))
        {
            if (atribute is Version)
            {
                Console.WriteLine("This is version {0} of the {1} class.",
                    (atribute as Version).Edition, typeof(TestClass).FullName);
            }
        }
    }
}