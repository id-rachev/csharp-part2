using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DurankulakNumbers
{
    static void Main()
    {
        string inputStr = Console.ReadLine();

        List<string> digitsArr = new List<string>();
        string digitStr01;
        string digitStr02;

        long powerBy168 = 1;
        long decimalNum = 0;

        for (int index = 0; index < inputStr.Length; index++)
        {
            if ((int)inputStr[index] > 90)
            {
                digitStr01 = new string(inputStr[index], 1);
                digitStr02 = new string(inputStr[index + 1], 1);
                index++;
                digitStr01 = digitStr01 + digitStr02;
                digitsArr.Add(digitStr01);
            }
            else
            {
                digitStr01 = new string(inputStr[index], 1);
                digitsArr.Add(digitStr01);
            }
        }



        for (int index = 0; index < digitsArr.Count; index++)
        {
            powerBy168 = 1;
            for (int pow = digitsArr.Count - 1; pow > index; pow--)
            {
                powerBy168 *= 16;
            }

            if (digitsArr[index].Length > 1)
            {
                char digit1 = digitsArr[index][0];
                char digit2 = digitsArr[index][1];
                
            }
            else
            {
                char digit = digitsArr[index][0];
                decimalNum += ((int)digit - 'A') * powerBy168;
            }

        }

        Console.WriteLine(decimalNum);

    }
}
