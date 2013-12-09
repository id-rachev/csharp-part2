using System;
using System.Linq;

class SortByElementsLength
{
    // You are given an array of strings. Write a method
    // that sorts the array by the length of its elements
    // (the number of characters composing them).

    static void Main()
    {
        string[] stringArr = new string[]
            { "one", "two", "three", "four", "five",
                "six", "seven", "eight", "nine", "ten" };

        ElementsLengthSort(stringArr);

        for (int index = 0; index < stringArr.Length; index++)
        {
            if (index < stringArr.Length - 1)
            {
                Console.Write("{0}, ", stringArr[index]);
            }
            else // index == stringArr.Length - 1
            {
                Console.Write("{0} ", stringArr[index]);
            }
        }
        Console.WriteLine();
    }

    private static void ElementsLengthSort(string[] stringArr)
    {
        string tempStr = "";

        for (int index = 1; index < stringArr.Length; index++)
        {
            if (stringArr[index].Length < stringArr[index - 1].Length)
            {
                tempStr = stringArr[index - 1];
                stringArr[index - 1] = stringArr[index];
                stringArr[index] = tempStr;

                ElementsLengthSort(stringArr);
            }
        }
    }
}
