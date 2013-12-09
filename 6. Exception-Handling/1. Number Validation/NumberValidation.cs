using System;
using System.Collections.Generic;
using System.Linq;

class NumberValidation
{
    // Write a program that reads an integer number and calculates
    // and prints its square root. If the number is invalid or negative,
    // print "Invalid number". In all cases finally print "Good bye".
    // Use try-catch-finally.

    static void Main()
    {
        Console.Write("Enter one positive integer number: ");

        try
        {
            int userNum = int.Parse(Console.ReadLine());

            if (userNum < 0)
            {
                throw new FormatException();
            }

            double sqrRootNum = Math.Sqrt(userNum);
            Console.WriteLine("Its square root is: {0}", sqrRootNum);

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
