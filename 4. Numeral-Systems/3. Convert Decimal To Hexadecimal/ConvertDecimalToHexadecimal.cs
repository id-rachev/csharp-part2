using System;
using System.Linq;
using System.Collections.Generic;

class ConvertDecimalToHexadecimal
{
    // Write a program to convert decimal numbers
    // to their hexadecimal representation.

    static void Main()
    {
        Console.Write("Enter one positive, integer number: ");
        int decimalNum = int.Parse(Console.ReadLine());

        int divident = decimalNum;
        byte remainder = new byte();
        List<char> binaryRep = new List<char>();

        do
        {
            remainder = (byte)(divident % 16);
            divident = divident / 16;

            if (remainder < 10)
            {
                remainder += 48;
            }
            else
            {
                remainder += 55;
            }

            binaryRep.Add((char)remainder);
        }
        while (divident > 0);

        binaryRep.Reverse();

        Console.Write("Its hexadecimal representation is: ");
        for (int index = 0; index < binaryRep.Count; index++)
        {
            Console.Write(binaryRep[index]);
        }
        Console.WriteLine();
    }
}
