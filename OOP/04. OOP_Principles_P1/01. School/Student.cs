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
            if (value>0)
            {
                this.classNumber = value;
            }
        }
    }
    public Student(string name) : base(name)
    {
        
    }
    public Student(string name, int classNumber) : base(name)
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