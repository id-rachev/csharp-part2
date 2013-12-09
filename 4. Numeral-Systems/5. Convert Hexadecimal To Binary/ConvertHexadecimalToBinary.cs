using System;
using System.Linq;

class ConvertHexadecimalToBinary
{
    // Write a program to convert hexadecimal numbers
    // to binary numbers (directly).

    static void Main()
    {
        Console.Write("Enter one hexadecimal number: ");
        string hexaNum = Console.ReadLine();

        string[] binArray = new string[] 
        {
            "0000", "0001", "0010", "0011", "0100", "0101", "0110", "0111",
            "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111"
        };

        for (int index = 0; index < hexaNum.Length; index++)
        {
            if (hexaNum[index] < 65)
            {
                Console.Write(binArray[hexaNum[index] - 48]);
            }
            else
            {
                Console.Write(binArray[hexaNum[index] - 55]);
            }

        }
        Console.WriteLine();
    }
}
