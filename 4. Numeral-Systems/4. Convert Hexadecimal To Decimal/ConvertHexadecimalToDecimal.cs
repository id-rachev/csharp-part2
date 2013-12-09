using System;
using System.Linq;

class ConvertHexadecimalToDecimal
{
    // Write a program to convert hexadecimal numbers
    // to their decimal representation.

    static void Main()
    {
        Console.Write("Enter one hexadecimal number: ");
        string hexaNum = Console.ReadLine();
        int decimalNum = new int();
        int powerBy16 = new int();

        for (int index = 0; index < hexaNum.Length; index++)
        {
            powerBy16 = 1;
            for (int pow = hexaNum.Length - 1; pow > index; pow--)
            {
                powerBy16 *= 16;
            }

            if (hexaNum[index] < 65)
            {
                decimalNum += (hexaNum[index] - 48) * powerBy16;
            }
            else
            {
                decimalNum += (hexaNum[index] - 55) * powerBy16;
            }
        }

        Console.WriteLine("Its decimal representation is: {0}", decimalNum);
    }
}
