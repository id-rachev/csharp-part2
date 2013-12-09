using System;
using System.Linq;

class RandomValues
{
    // Write a program that generates and prints
    // to the console 10 random values in the range [100, 200].

    static void Main()
    {
        Random randomizator = new Random();
        int randomValues = new int();

        for (int count = 0; count < 10; count++)
        {
            randomValues = randomizator.Next(100, 201);
            Console.Write("{0} ", randomValues);
        }
        Console.WriteLine();
    }
}
