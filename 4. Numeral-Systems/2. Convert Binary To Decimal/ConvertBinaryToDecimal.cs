using System;
using System.Linq;

class ConvertBinaryToDecimal
{
    // Write a program to convert binary numbers
    // to their decimal representation.

    static void Main()
    {
        Console.Write("Enter one binary number: ");
        string binaryNum = Console.ReadLine();
        int decimalNum = new int();
        int powerByTwo = new int();

        for (int index = 0; index < binaryNum.Length; index++)
        {
            powerByTwo = 1;
            for (int pow = binaryNum.Length - 1; pow > index; pow--)
			{
                powerByTwo *= 2;
            }

            decimalNum += (binaryNum[index] - '0') * powerByTwo;
        }

        Console.WriteLine("Its decimal representation is: {0}", decimalNum);
    }
}
