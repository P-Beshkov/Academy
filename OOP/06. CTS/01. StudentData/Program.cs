/*01. Define a class Student, which contains data about a student 
* – first, middle and last name, SSN, permanent address, mobile phone,
* e-mail, course, specialty, university, faculty. Use an enumeration 
* for the specialties, universities and faculties. Override the
* standard methods, inherited by  System.Object: Equals(), 
* ToString(), GetHashCode() and operators == and !=. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student : ICloneable, IComparable<Student>
{
    private static uint counter = 1;
    private string firtName;
    private string middleName;
    private string lastName;
    private uint sSN;
    private string address;
    private string email;
    private uint course;
    private Specialty spec;
    private University uni;
    private Faculty fac;

    public Student(string FirstName, string MiddleName, string LastName, University uni, Faculty fac, Specialty spec,
        string address = "Not defined", string email = "Not given", uint course = 1)
    {
        this.FirstName = FirstName;
        this.MiddleName = MiddleName;
        this.LastName = LastName;
        this.uni = uni;
        this.fac = fac;
        this.spec = spec;
        this.Address = address;
        this.Email = email;
        this.Course = course;
        this.sSN = counter++;
    }

    public uint Course
    {
        get
        {
            return this.course;
        }
        private set
        {
            if (value <= 0 || value >= 6)
            {
                throw new ArgumentOutOfRangeException("Course must be positive below 6");
            }
            this.course = value;
        }
    }

    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            if (value == null || value == String.Empty || value.Length < 5)
            {
                throw new ArgumentOutOfRangeException("E-mail must be at least 5 characters");
            }
            this.email = value;
        }
    }

    public string Address
    {
        get
        {
            return this.address;
        }
        private set
        {
            if (value == null || value == String.Empty || value.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Address must be at least 3 characters");
            }
            this.address = value;
        }
    }

    public uint SSN
    {
        get
        {
            return this.sSN;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value == null || value == String.Empty || value.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Name must be at least 3 characters");
            }
            this.lastName = value;
        }
    }

    public string MiddleName
    {
        get
        {
            return this.middleName;
        }
        private set
        {
            if (value == null || value == String.Empty || value.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Name must be at least 3 characters");
            }
            this.middleName = value;
        }
    }

    public string FirstName
    {
        get
        {
            return this.firtName;
        }
        private set
        {
            if (value == null || value == String.Empty || value.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Name must be at least 3 characters");
            }
            this.firtName = value;
        }
    }

    // override object.Equals
    public override bool Equals(object obj)
    {
        if (obj == null || this.GetType() != obj.GetType())
        {
            return false;
        }

        // TODO: write your implementation of Equals() here
        Student given = (Student)obj;
        if (this.FirstName == given.FirstName && this.MiddleName == given.MiddleName &&
            this.LastName == given.LastName && this.SSN == given.SSN)
        {
            return true;
        }
        return base.Equals(obj);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        int code = (int)(this.SSN ^ this.Course);
        return code;
    }

    public override string ToString()
    {
        string fullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
        return String.Format("{0} - {1} course, SSN:{2}", fullName, this.Course, this.SSN);
    }

    public static bool operator ==(Student left, Student right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Student left, Student right)
    {
        return !left.Equals(right);
    }

    public object Clone()
    {
        return new Student(this.FirstName, this.MiddleName, this.LastName, this.uni,
            this.fac, this.spec, this.Address, this.Email, this.Course);
    }

    public int CompareTo(Student other)
    {
        string leftFullname = this.FirstName + this.MiddleName + this.LastName;
        string rightFullname = other.FirstName + other.MiddleName + other.LastName;
        int firstCompare = leftFullname.CompareTo(rightFullname);
        if (firstCompare < 0)
        {
            return -1;
        }
        else if (firstCompare > 0)
        {
            return 1;
        }
        else
        {
            firstCompare = this.SSN.CompareTo(other.SSN);
            if (firstCompare < 0)
            {
                return -1;
            }
            else if (firstCompare > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

public enum Specialty
{
    Applied_Math,
    Physics,
    Software_Engineer
}

;
public enum University
{
    SU,
    Tu_Sofia,
    UNSS
}

;
public enum Faculty
{
    Computing,
    Economic,
    Math
};

class Program
{
    static void Main()
    {
    }
}