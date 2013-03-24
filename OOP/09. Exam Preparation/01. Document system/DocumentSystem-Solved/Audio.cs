using System;
using System.Text;

class Audio : Multimedia
{
    private int? sampleRate;
    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();
        temp.Append("AudioDocument[");
        if (this.Content!=null)
        {
            temp.Append("content=" + this.Content + ";");
        }
        if (this.Lenght!=null)
        {
            temp.Append("length=" + this.Lenght + ";");
        }
        temp.Append("name=" + this.Name + ";");
        if (this.SampleRate!=null)
        {
            temp.Append("samplerate=" + this.SampleRate + ";");
        }
        if (this.Size!=null)
        {
            temp.Append("size=" + this.Size + ";");
        }
        temp[temp.Length - 1] = ']';
        return temp.ToString();
    }
    public override void LoadProperty(string key, string value)
    {
        base.LoadProperty(key, value);
    }  
     
    public Audio(string name) : this(name,null,null,null,null)
    {
    }
    public Audio(string name, string content, long? size, int? lenght, int? sampleRate) : base(name, content, size, lenght)
    {
        this.SampleRate = sampleRate;
    }
    public int? SampleRate
    {
        get
        {
            return this.sampleRate;
        }
        set
        {
            this.sampleRate = value;
        }
    }
}