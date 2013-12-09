using System;
using System.Linq;

class ReverseString
{
    // Write a program that reads a string, reverses it and
    // prints the result at the console. Example: "sample"  "elpmas".

    static void Main()
    {
        Console.Write("Enter a word or short text (string): ");
        string userInput = Console.ReadLine();

        char[] appOutput = new char[userInput.Length];

        for (int index = 0; index < userInput.Length; index++)
        {
            appOutput[index] = userInput[userInput.Length - 1 - index];
            Console.Write(appOutput[index]);
        }
        Console.WriteLine();
    }
}
