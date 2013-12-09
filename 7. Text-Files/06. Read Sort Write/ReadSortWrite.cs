using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class ReadSortWrite
{
    // Write a program that reads a text file containing a list
    // of strings, sorts them and saves them to another text file.

    static void Main()
    {
        List<string> textContent = new List<string>();

        StreamReader textToRead = new StreamReader("fileToRead.txt");
        using (textToRead)
        {
            string textLine;
            while ((textLine = textToRead.ReadLine()) != null)
            {
                textContent.Add(textLine);
            }
        }

        textContent.Sort();

        StreamWriter textToWrite = new StreamWriter("fileToWrite.txt");
        using (textToWrite)
        {
            for (int index = 0; index < textContent.Count; index++)
            {
                textToWrite.WriteLine(textContent[index]); 
            }
        }
    }
}