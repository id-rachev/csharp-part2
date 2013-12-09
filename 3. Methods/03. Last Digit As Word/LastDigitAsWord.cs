using System;

class LastDigitAsWord
{
    // Write a method that returns the last digit of given
    // integer as an English word.

    static string LastDigitToWord(string numToWord)
    {
        char lastDigit = numToWord[numToWord.Length - 1];

        string[] digitWordsArr = new string[]
        { "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine" };

        int arrayIndex;
        for (arrayIndex = 0; arrayIndex < digitWordsArr.Length; arrayIndex++)
        {
            if (arrayIndex == (lastDigit - 48))
            {
                break;
            }
        }
        return digitWordsArr[arrayIndex];
    }

    static void Main()
    {
        Console.Write("Enter one integer number: ");
        string numToWord = Console.ReadLine();

        Console.WriteLine("The \"last-digit-word\" is: {0}.",
            LastDigitToWord(numToWord));
    }
}

