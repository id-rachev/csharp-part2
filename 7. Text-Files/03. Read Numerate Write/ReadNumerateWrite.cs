using System;
using System.Linq;
using System.IO;

class ReadNumerateWrite
{
    // Write a program that reads a text file and inserts
    // line numbers in front of each of its lines.
    // The result should be written to another text file.

    static void Main()
    {
        StreamReader fileToRead = new StreamReader("fileToRead.txt");
        using (fileToRead)
        {
            StreamWriter newFileToWrite = new StreamWriter("newFileToWrite.txt");
            using (newFileToWrite)
            {
                string textLine;
                int lineCount = new int();

                while ((textLine = fileToRead.ReadLine()) != null)
                {
                    lineCount++;
                    newFileToWrite.WriteLine("{0}. {1}", lineCount, textLine);
                }
            }

        }
    }
}
