using System;

public class Animal
{
    private int age;
    private string name;
    private bool isFemale;

    public bool IsFemale
    {
        get
        {
            return this.isFemale;
        }
        set
        {
            this.isFemale = value;
        }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        protected set
        {
            if (value != null && value != String.Empty)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Name can't be null or empty");
            }
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        protected set
        {
            if (value >= 0)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Age must be positive");
            }
        }
    }

    public Animal(string name, bool isFemale)
    {
        this.Name = name;
        this.isFemale = isFemale;
    }

    public Animal(string name, bool isFemale, int age) : this(name,isFemale)
    {
        this.Age = age;
    }
}