/*04. Create a class Person with two fields – name and age. Age can
 * be left unspecified (may contain null value. Override ToString() 
 * to display the information of a person and if age is not 
 * specified – to say so. Write a program to test this functionality. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private int? age;

    public Person(string name)
    {
        this.Name = name;
        this.Age = null;
    }
    public Person(string name, int? age) : this(name)
    {
        this.Age = age;
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int? Age
    {
        get
        {            
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }

    public override string ToString()
    {
        string ageResult = this.Age != null ? this.Age.ToString() : "Not specified";
        return String.Format("Name: {0}\nAge: {1}",this.Name,ageResult);
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("I don't have age :D");
        Person p2 = new Person("Pavel", 24);
        Console.WriteLine(p1);
        Console.WriteLine();
        Console.WriteLine(p2);
    }
}