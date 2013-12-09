using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

class ConcatTwoTextFiles
{
    // Write a program that concatenates two text files
    // into another text file.

    static void Main()
    {
        StreamWriter newConcatFile = new StreamWriter("newConcatFile.txt");
        using (newConcatFile)
        {
            StreamReader fileToRead1 = new StreamReader("fileToRead1.txt");
            using (fileToRead1)
            {
                string lineFile1;
                while ((lineFile1 = fileToRead1.ReadLine()) != null)
                {
                    newConcatFile.WriteLine(lineFile1);
                }
            }
            StreamReader fileToRead2 = new StreamReader("fileToRead2.txt");
            using (fileToRead2)
            {
                string lineFile2;
                while ((lineFile2 = fileToRead2.ReadLine()) != null)
                {
                    newConcatFile.WriteLine(lineFile2);
                }
            }
        }
    }
}
