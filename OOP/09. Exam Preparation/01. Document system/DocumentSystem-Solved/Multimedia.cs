using System;

abstract class Multimedia : Binary
{
    private int? lenght;
    public Multimedia(string name, string content, long? size, int? lenght) : base(name, content,size)
    {
        this.Lenght = lenght;
    }
    public int? Lenght
    {
        get
        {
            return this.lenght;
        }
        set
        {
            this.lenght = value;
        }
    }
}