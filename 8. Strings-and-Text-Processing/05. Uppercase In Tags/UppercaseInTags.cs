using System;
using System.Linq;

class UppercaseInTags
{
    static void Main()
    {
        // You are given a text. Write a program that changes the text in all
        // regions surrounded by the tags <upcase> and </upcase> to uppercase.
        // The tags cannot be nested. 

        string givenText =
            "We are living in a <upcase>yellow submarine</upcase>. " +
            "We don't have <upcase>anything</upcase> else.";

        string openTag = "<upcase>";
        string closeTag = "</upcase>";
        string upCaseSub;
        string tagsToTrim;

        int startIndex = givenText.IndexOf(openTag);
        int endIndex = givenText.IndexOf(closeTag);

        while (startIndex != -1)
        {
            while (endIndex != -1)
            {
                tagsToTrim = givenText.Substring(startIndex, endIndex + closeTag.Length - startIndex);
                upCaseSub = givenText.Substring(startIndex + openTag.Length, endIndex - startIndex - openTag.Length);
                givenText = givenText.Replace(tagsToTrim, upCaseSub.ToUpper());

                startIndex = givenText.IndexOf(openTag);
                endIndex = givenText.IndexOf(closeTag);
                break;
            }
        }

        Console.WriteLine(givenText);
    }
}
