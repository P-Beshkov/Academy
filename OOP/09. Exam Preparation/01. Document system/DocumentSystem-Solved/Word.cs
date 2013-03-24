using System;
using System.Text;

class Word : Office, IEncryptable, IEditable
{
    private long? charsCount;
    public override string ToString()
    {
        
        StringBuilder temp = new StringBuilder();
        temp.Append("WordDocument[");
        if (this.isEncrypted)
        {
            temp.Append("encrypted]");
            return temp.ToString();
        }
        if (this.CharsCount!=null)
        {
            temp.Append("chars=" + this.CharsCount + ";");
        }
        if (this.Content != null)
        {
            temp.Append("content=" + this.Content + ";");
        }        
        temp.Append("name=" + this.Name + ";");
        
        if (this.Size != null)
        {
            temp.Append("size=" + this.Size + ";");
        }
        if (this.Version != null)
        {
            temp.Append("version=" + this.Version + ";");
        }
        temp[temp.Length - 1] = ']';
        return temp.ToString();
    }
    public void ChangeContent(string newContent)
    {
        // TODO: Implement this method
        throw new NotImplementedException();
    }
    private bool isEncrypted;
    public override void LoadProperty(string key, string value)
    {
        if (key == "IsEncrypted")
        {
            if (value == "true")
            {
                this.Encrypt();
            }
            else
            {
                this.Decrypt();
            }
        }
    }
    public bool IsEncrypted
    {
        get
        {
            return this.isEncrypted;
        }
    }

    public void Encrypt()
    {
        this.isEncrypted = true;
    }

    public void Decrypt()
    {
        this.isEncrypted = false;
    }

    public long? CharsCount
    {
        get
        {
            return this.charsCount;
        }
        set
        {
            this.charsCount = value;
        }
    }
    public Word(string name) : this(name, null,null,null,null)
    {
        this.isEncrypted = false;
    }

    public Word(string name, string content, long? size, string version, long? charsCount) : base(name, content, size, version)
    {
        this.CharsCount = charsCount;
    }
}