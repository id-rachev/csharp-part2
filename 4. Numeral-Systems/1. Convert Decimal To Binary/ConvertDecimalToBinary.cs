using System;
using System.Linq;
using System.Collections.Generic;

class ConvertDecimalToBinary
{
    // Write a program to convert decimal numbers
    // to their binary representation.

    static void Main()
    {
        Console.Write("Enter one positive, integer number: ");
        int decimalNum = int.Parse(Console.ReadLine());

        int divident = decimalNum;
        byte remainder = new byte();
        List<bool> binaryRep = new List<bool>();

        do
        {
            remainder = (byte)(divident % 2);
            divident = divident / 2;

            if (remainder == 1)
            {
                binaryRep.Add(true);
            }
            else
            {
                binaryRep.Add(false);
            }
        }
        while (divident > 0);

        binaryRep.Reverse();

        Console.Write("Its binary representation is: ");
        for (int index = 0; index < binaryRep.Count; index++)
        {
            if (binaryRep[index])
            {
                Console.Write(1);
            }
            else
            {
                Console.Write(0);
            }
        }
        Console.WriteLine();
    }
}
