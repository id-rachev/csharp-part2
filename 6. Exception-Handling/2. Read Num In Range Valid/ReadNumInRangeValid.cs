using System;
using System.Linq;

class ReadNumInRangeValid
{
    // Write a method ReadNumber(int start, int end) that enters
    // an integer number in given range [start…end]. If an invalid
    // number or non-number text is entered, the method should throw
    // an exception. Using this method write a program that enters
    // 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

    static int[] inputNumArr = new int[10];

    static void Main()
    {
        Console.WriteLine("Enter 10 numbers in the range [1..100], " +
            "such that 1 < a1 < … < a10 < 100");

        ReadNumber(1, 100);
    }

    static void ReadNumber(int start, int end)
    {
        try
        {
            for (int count = 0; count < 10; count++)
            {
                Console.Write("Enter next number: ");
                inputNumArr[count] = int.Parse(Console.ReadLine());

                if ((start < inputNumArr[count]) && (inputNumArr[count] < end))
                {
                    if (count != 0)
                    {
                        if (inputNumArr[count] > inputNumArr[count - 1])
                        {
                            continue;
                        }
                        else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        catch (FormatException)
        {
            throw;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
