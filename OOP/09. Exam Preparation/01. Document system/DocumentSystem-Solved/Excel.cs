using System;
using System.Text;

class Excel : Office, IEncryptable
{
    private int? rowsCount;
    private int? colsCount;
    private bool isEncrypted;
    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();
        temp.Append("ExcelDocument[");
        if (this.IsEncrypted)
        {
            temp.Append("encrypted]");
            return temp.ToString();
        }
        if (this.ColsCount!=null)
        {
            temp.Append("cols=" + this.ColsCount + ";");
        }
        if (this.Content!=null)
        {
            temp.Append("content=" + this.Content + ";");
        }
        temp.Append("name=" + this.Name + ";");
        if (this.RowsCount!=null)
        {
            temp.Append("rows=" + this.RowsCount + ";");
        }
        if (this.Size!=null)
        {
            temp.Append("size=" + this.Size + ";");
        }
        if (this.Version!=null)
        {
            temp.Append("version=" + this.Version + ";");
        }
        temp[temp.Length - 1] = ']';
        return temp.ToString();
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

    public int? RowsCount
    {
        get
        {
            return this.rowsCount;
        }
        set
        {
            this.rowsCount = value;
        }
    }

    public int? ColsCount
    {
        get
        {
            return this.colsCount;
        }
        set
        {
            this.colsCount = value;
        }
    }
    public Excel(string name) : this(name,null,null,null,null,null)
    {
    }
    public Excel(string name, string content, long? size, string version, int? rows, int? cols) : base(name,content,size,version)
    {
        this.RowsCount = rows;
        this.ColsCount = cols;
    }
}