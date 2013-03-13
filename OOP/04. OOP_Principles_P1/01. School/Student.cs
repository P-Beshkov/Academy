using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Student : Human
{
    private int classNumber;

    public int ClassNumber
    {
        get
        {
            return this.classNumber;
        }
        protected set
        {
            if (value > 0)
            {
                this.classNumber = value;
            }
        }
    }

    public Student(string name) : this(name,1,"")
    {
    }

    public Student(string name, string comment) : this(name,1,comment)
    {
    }

    public Student(string name, int classNumber) : this(name,classNumber,"")
    {
    }

    public Student(string name, int classNumber, string comment) : base(name,comment)
    {
        this.ClassNumber = classNumber;
    }

    public static Student CreateStudent(int number)
    {
        Console.WriteLine("Student name: ");
        string name = Console.ReadLine();

        return new Student(name,number);
    }
}