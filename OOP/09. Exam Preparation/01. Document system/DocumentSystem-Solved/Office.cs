using System;

abstract class Office : Binary
{
    private string version;
    public Office(string name) : this(name,null,null,null)
    {
    }
    public Office(string name, string content, long? size, string version) : base(name, content,size)
    {
        this.Version = version;
    }

    public string Version
    {
        get
        {
            return this.version;
        }
        set
        {
            this.version = value;
        }
    }
}