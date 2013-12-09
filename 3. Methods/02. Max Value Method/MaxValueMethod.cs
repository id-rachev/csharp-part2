using System;

class MaxValueMethod
{
    // Write a method GetMax() with two parameters that returns
    // the bigger of two integers. Write a program that reads
    // 3 integers from the console and prints the biggest of them
    // using the method GetMax().

    static int GetMax(int numberA, int numberB)
    {
        int maxNum = numberA;
        if (numberB > numberA)
        {
            maxNum = numberB;
        }
        return maxNum;
    }

    static void Main()
    {
        Console.Write("Enter one integer number, A = ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number, B = ");
        int secondNum = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number, C = ");
        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine("The bigest number is: {0}",
            GetMax(GetMax(firstNum, secondNum), thirdNum));
    }
}
