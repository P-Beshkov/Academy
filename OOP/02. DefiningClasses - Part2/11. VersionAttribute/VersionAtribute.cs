using System;

[AttributeUsage(AttributeTargets.Struct |
    AttributeTargets.Class |
    AttributeTargets.Interface |
    AttributeTargets.Enum |
    AttributeTargets.Method)]
class Version : Attribute
{
    private string edition;
    private int major;
    private int minor;
    public Version(int major,int minor)
    {
        this.major = major;
        this.minor = minor;
    }
    public string Edition
    {
        get
        {
            return major + "." + minor;
        }
    }
}
