using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays
        //lexicographically (letter by letter).


        Console.Write("Enter first char array in one line: ");
        string firstArr = Console.ReadLine();

        Console.Write("Enter second char array in one line: ");
        string secondArr = Console.ReadLine();

        int minLengthArr = new int();
        bool equalArrays = new bool();
        bool firstArrIsFirst = new bool();

        if (firstArr.Length < secondArr.Length)
        {
            minLengthArr = firstArr.Length;
            firstArrIsFirst = true;
        }
        else if (firstArr.Length > secondArr.Length)
        {
            minLengthArr = secondArr.Length;
        }
        else
        {
            minLengthArr = firstArr.Length;
            equalArrays = true;
        }

        for (int index = 0; index < minLengthArr; index++)
        {
            if (firstArr[index] == secondArr[index])
            {
                continue;
            }
            else if (firstArr[index] < secondArr[index])
            {
                firstArrIsFirst = true;
                equalArrays = false;
                break;
            }
            else
            {
                firstArrIsFirst = false;
                equalArrays = false;
                break;
            }
        }

        Console.WriteLine("The first array is lexicographically " +
            "before the second array is: {0}!", firstArrIsFirst);
        Console.WriteLine("This two arrays are equal is: {0}!", equalArrays);
    }
}

