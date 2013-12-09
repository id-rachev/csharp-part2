using System;
using System.Collections.Generic;
using System.Linq;

class DayOfWeek
{
    // Write a program that prints to the console
    // which day of the week is today. Use System.DateTime.

    static void Main()
    {
        Console.WriteLine(
            "The day of week for today is: {0}.", DateTime.Now.DayOfWeek);
    }
}
