using System;
using System.Text;

class Text : Document, IEditable
{
    private string charSet;
    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();
        temp.Append("TextDocument[");
        if (this.CharSet!=null)
        {
            temp.Append("charset=" + this.CharSet + ";");
        }
        if (this.Content != null)
        {
            temp.Append("content=" + this.Content + ";");
        }        
        temp.Append("name=" + this.Name + ";");        
        temp[temp.Length - 1] = ']';
        return temp.ToString();
    }
    public Text(string name) : this(name,null,null)
    {
    }
    public Text(string name, string content) : this(name,content,null)
    {
    }
    public Text(string name, string content, string charSet) : base(name,content)
    {
        this.CharSet = charSet;
    }
    public void ChangeContent(string newContent)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }

    public string CharSet
    {
        get
        {
            return this.charSet;
        }
        set
        {
            this.charSet = value;
        }
    }
}