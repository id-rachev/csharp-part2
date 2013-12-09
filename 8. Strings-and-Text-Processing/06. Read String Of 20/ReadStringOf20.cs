using System;
using System.Linq;

class ReadStringOf20
{
    // Write a program that reads from the console a string of maximum 20 characters.
    // If the length of the string is less than 20, the rest of the characters should
    // be filled with '*'. Print the result string into the console.

    static void Main()
    {
        Console.WriteLine("Enter a text (string) of maximum 20 characters: ");
        string inputStr = Console.ReadLine();

        int maxLength = 20;
        string outputStr;

        if (inputStr.Length >= maxLength)
        {
            outputStr = inputStr.Substring(0, maxLength);
        }
        else
        {
            outputStr = inputStr.PadRight(maxLength, '*');
        }

        Console.WriteLine("The result is: {0}", outputStr);
    }
}
