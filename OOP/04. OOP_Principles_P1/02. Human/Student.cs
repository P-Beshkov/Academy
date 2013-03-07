/* Define new class Student which is derived from Human and has 
 * new field – grade. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student : Human
{
    private int grade;
    public int Grade
    {
        get
        {
            return this.grade;
        }
        set
        {
            if (value>0)
            {
                this.grade = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Grade must be positive");
            }
        }
    }
    public Student (string first, string second, int  grade) : base(first,second)
    {
        this.Grade = grade;
    }
}