using System;

public abstract class Binary : Document
{
    private long? size;
    public Binary(string name) : this(name,null,null)
    {
    }
    public Binary(string name, string content) : this(name,content,null)
    {
    }
    public Binary(string name, string content, long? size) : base(name, content)
    {
        this.Size = size;
    }
    public long? Size
    {
        get
        {
            return this.size;
        }
        set
        {
            this.size = value;
        }
    }
}