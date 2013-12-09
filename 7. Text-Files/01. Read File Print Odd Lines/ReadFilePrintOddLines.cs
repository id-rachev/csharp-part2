using System;
using System.Linq;
using System.IO;

class ReadFilePrintOddLines
{
    static void Main()
    {
        StreamReader textFileRead = new StreamReader("Text-File-To-Read.txt");

        using (textFileRead)
        {
            string currentLine = textFileRead.ReadLine();
            int lineCount = new int();

            while (currentLine != null)
            {
                lineCount++;
                if (lineCount % 2 == 1)
                {
                    Console.WriteLine(currentLine);
                }
                currentLine = textFileRead.ReadLine();
            }
        }
    }
}
