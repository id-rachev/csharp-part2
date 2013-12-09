using System;

class CountAppearsInArray
{
    // Write a method that counts how many times given number
    // appears in given array. Write a test program to check
    // if the method is working correctly.

    static int CountAppears(int[] userArray, int numberToCheck)
    {
        int countNumber = new int();

        foreach (int numElement in userArray)
        {
            if (numElement == numberToCheck)
            {
                countNumber++;
            }
        }
        return countNumber;
    }
    static void Main()
    {
        Console.Write("Enter one integer number, N = ");
        int numberToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter sequence of int numbers, " +
            "to check how many times N appears in this array! ");

        Console.Write("Enter the array length: ");
        int arrLength = int.Parse(Console.ReadLine());

        int[] userArray = new int[arrLength];
        for (int arrIndex = 0; arrIndex < arrLength; arrIndex++)
        {
            Console.Write("Enter next element of the array: ");
            userArray[arrIndex] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Number N is appears {0} times in this array!",
            CountAppears(userArray, numberToCheck));
    }
}
