using System;
using System.Linq;
using System.Text;

class ConvertBinaryToHexadecimal
{
    // Write a program to convert binary numbers
    // to hexadecimal numbers (directly).

    static void Main()
    {
        Console.Write("Enter one binary number in format of 4 symbols: ");
        string binaryNum = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(binaryNum));
    }

    static string ConvertBinToHex(string binaryNum)
    {
        int strLength = binaryNum.Length;
        StringBuilder strSequence = new StringBuilder();

        for (int index = 0; index < strLength; index = index + 4)
        {
            switch (binaryNum.Substring(index, 4))
            {
                case "1010": strSequence.Append("A"); break;
                case "1011": strSequence.Append("B"); break;
                case "1100": strSequence.Append("C"); break;
                case "1101": strSequence.Append("D"); break;
                case "1110": strSequence.Append("E"); break;
                case "1111": strSequence.Append("F"); break;
                case "0000": strSequence.Append("0"); break;
                case "0001": strSequence.Append("1"); break;
                case "0010": strSequence.Append("2"); break;
                case "0011": strSequence.Append("3"); break;
                case "0100": strSequence.Append("4"); break;
                case "0101": strSequence.Append("5"); break;
                case "0110": strSequence.Append("6"); break;
                case "0111": strSequence.Append("7"); break;
                case "1000": strSequence.Append("8"); break;
                case "1001": strSequence.Append("9"); break;
            }
        }
        return strSequence.ToString();
    }
}
