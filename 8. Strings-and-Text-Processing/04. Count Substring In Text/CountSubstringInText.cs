using System;
using System.Linq;

class CountSubstringInText
{
    static void Main()
    {
        // Write a program that finds how many times a substring is
        // contained in a given text (perform case insensitive search).

        string givenText =
            "We are living in an yellow submarine. We don't have anything else. " +
            "Inside the submarine is very tight. So we are drinking all the day. " +
            "We will move out of it in 5 days.";
        string targetSub = "in";
        int countSub = new int();
        string lowCaseText = givenText.ToLower();
        int index = lowCaseText.IndexOf(targetSub);

        while ((index < lowCaseText.Length) && (index != -1))
        {
            countSub++;
            index = lowCaseText.IndexOf(targetSub, index + 1);
        }
        Console.WriteLine(
            "The substring '{0}' is contained {1} times in the text.", targetSub, countSub);
    }
}
