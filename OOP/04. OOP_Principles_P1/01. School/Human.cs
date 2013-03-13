using System;

public class Human
{
    private string name;

    public string Name
    {
        get
        {
            return this.name;
        }
        protected set
        {
            if (value != null)
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentNullException("Name can't be null");
            }
        }
    }

    public string Comment { get; set; }

    public Human(string name)
    {
        this.Name = name;
    }

    public Human(string name, string comment) : this(name)
    {
        this.Comment = comment;
    }
}