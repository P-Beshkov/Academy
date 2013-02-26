using System.Text;
using System;
static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder builder, int index, int length)
    {
        if (index+length>=builder.Length)
        {
            throw new ArgumentOutOfRangeException("Index+Length must be less than StringBuilder's length");
        }
        StringBuilder sub = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            sub.Append(builder[index + i]);
        }
        return sub.ToString();
    }
}