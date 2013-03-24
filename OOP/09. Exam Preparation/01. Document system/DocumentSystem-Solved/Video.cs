using System;
using System.Text;

class Video : Multimedia
{
    private int? frameRate;
    public override string ToString()
    {
        StringBuilder temp = new StringBuilder();
        temp.Append("VideoDocument[");
        if (this.Content != null)
        {
            temp.Append("content=" + this.Content + ";");
        }
        if (this.FrameRate != null)
        {
            temp.Append("framerate=" + this.FrameRate + ";");
        }
        if (this.Lenght != null)
        {
            temp.Append("length=" + this.Lenght + ";");
        }
        temp.Append("name=" + this.Name + ";");        
        if (this.Size != null)
        {
            temp.Append("size=" + this.Size + ";");
        }
        temp[temp.Length - 1] = ']';
        return temp.ToString();
    }
    public Video(string name) : this(name,null,null,null,null)
    {
    }
    public Video(string name, string content, long? size, int? lenght, int? frameRate) : base(name, content, size, lenght)
    {
        this.FrameRate = frameRate;
    }
    public int? FrameRate
    {
        get
        {
            return this.frameRate;
        }
        set
        {
            this.frameRate = value;
        }
    }
}