using System;
using System.Text;

class PDF : Binary, IEncryptable
{
    private int? pagesCount;
    private bool isEncrypted;

    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();
        temp.Append("PDFDocument[");
        if (this.isEncrypted)
        {
            temp.Append("encrypted]");
            return temp.ToString();
        }
        if (this.Content != null)
        {
            temp.Append("content=" + this.Content+";");
        }
        temp.Append("name=" + this.Name+";");
        if (this.PagesCount != null)
        {
            temp.Append("pages=" + this.PagesCount+";");
        }
        if (this.Size != null)
        {
            temp.Append("size=" + this.Size+";");
        }
        temp[temp.Length-1] = ']';
        return temp.ToString();
    }

    public PDF(string name) : base(name)
    {
        this.isEncrypted = false;
    }

    public PDF(string name, string content, long? size, int? pagesCount) : base(name, content, size)
    {
        this.PagesCount = pagesCount;
    }

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

    public int? PagesCount
    {
        get
        {
            return this.pagesCount;
        }
        set
        {
            this.pagesCount = value;
        }
    }
}