using System;
using System.Collections.Generic;
using System.Linq;
class SumOfSubstrings
{
    // You are given a sequence of positive integer values written
    // into a string, separated by spaces. Write a function that reads
    // these values from given string and calculates their sum. 

    static void Main()
    {
        string givenStr = "43 68 9 23 318";

        string[] splitedStrArr = givenStr.Split(' ');
        int sumResult = new int();

        for (int index = 0; index < splitedStrArr.Length; index++)
        {
            sumResult += int.Parse(splitedStrArr[index]);
        }

        Console.WriteLine("string = \"{0}\" -> result = {1}", givenStr, sumResult);
    }
}
