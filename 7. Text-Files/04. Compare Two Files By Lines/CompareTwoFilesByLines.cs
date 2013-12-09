using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

// Write a program that compares two text files
// line by line and prints the number of lines that are
// the same and the number of lines that are different.
// Assume the files have equal number of lines.

class CompareTwoFilesByLines
{
    static void Main()
    {
        StreamReader textToRead1 = new StreamReader("fileToRead1.txt");
        using (textToRead1)
        {
            StreamReader textToRead2 = new StreamReader("fileToRead2.txt");
            using (textToRead2)
            {
                string textLine1;
                string textLine2;
                int lineNumber = new int();
                List<int> equalLinesNums = new List<int>();
                List<int> differentLinesNums = new List<int>();

                while ((textLine1 = textToRead1.ReadLine()) != null)
                {
                    lineNumber++;
                    textLine2 = textToRead2.ReadLine();

                    if (textLine1 == textLine2)
                    {
                        equalLinesNums.Add(lineNumber);
                    }
                    else
                    {
                        differentLinesNums.Add(lineNumber);
                    }
                }

                Console.Write("The equal lines numbers are:");
                foreach (var number in equalLinesNums)
                {
                    Console.Write(" {0}", number);
                }
                Console.WriteLine();

                Console.Write("The different lines numbers are:");
                foreach (var number in differentLinesNums)
                {
                    Console.Write(" {0}", number);
                }
                Console.WriteLine();
            }
        }
    }
}
