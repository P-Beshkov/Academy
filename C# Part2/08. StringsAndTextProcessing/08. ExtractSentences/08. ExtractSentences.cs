/*08. Write a program that extracts from a given text all sentences containing 
 * given word. 	Example: The word is "in". The text is:
 * We are living in a yellow submarine. We don't have anything else. 
 * Inside the submarine is very tight. So we are drinking all the day. 
 * We will move out of it in 5 days.
 * 	The expected result is:
 * 	We are living in a yellow submarine.
 * 	We will move out of it in 5 days.
 * 	Consider that the sentences are separated by "." and the 
 * 	words – by non-letter symbols. */

using System;
using System.Text;

class Program
{
    static private string ExtractSentencesWith(string text, string word)
    {
        StringBuilder buffer = new StringBuilder();
        string sentence;
        int startIndex;
        int dotIndex = text.IndexOf(".");
        int sentenceLenght = dotIndex;
        sentence = text.Substring(0, sentenceLenght);
        while (dotIndex != -1)
        {
            int indexIn = sentence.IndexOf("in");
            if (indexIn != -1)
            {
                if (sentence[indexIn - 1] == ' ')
                {
                    buffer.Append(sentence);
                }
            }
            int prevDot = dotIndex;
            dotIndex = text.IndexOf(".", dotIndex + 1);
            if (dotIndex == -1)
            {
                return buffer.ToString();
            }
            sentence = text.Substring(prevDot + 1, dotIndex - prevDot);
        }

        return buffer.ToString();
    }
    static void Main()
    {
        string text="We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string Extracted = ExtractSentencesWith(text, word);
        Console.WriteLine(Extracted);
    }
}