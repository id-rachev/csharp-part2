using System;

class YearLeap
{
    //Write a program that reads a year from the console
    // and checks whether it is a leap. Use DateTime.

    static void Main()
    {
        Console.Write("Enter a year to check is it a leap year: ");
        int yearToCheck = int.Parse(Console.ReadLine());

        Console.WriteLine("It's a leap year is: {0}", DateTime.IsLeapYear(yearToCheck));
    }
}

