using System;
using System.Collections.Generic;

public abstract class Document : IDocument
{
    private string name;
    private string content;

    public virtual void LoadProperty(string key, string value)
    {
        throw new NotImplementedException();
    }
    public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        throw new NotImplementedException();
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

    public string Content
    {
        get
        {
            return this.content;
        }
        set
        {
            this.content = value;
        }
    }
    public Document(string name) : this(name,null)
    {
    }
    public Document(string name, string content)
    {
        this.Name = name;
        this.Content = content;
    }
}