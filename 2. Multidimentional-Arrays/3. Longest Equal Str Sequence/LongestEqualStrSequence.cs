using System;
using System.Linq;

class LongestEqualStrSequence
{
    static void Main()
    {
        // We are given a matrix of strings of size N x M.
        // Sequences in the matrix we define as sets of several neighbor
        // elements located on the same line, column or diagonal.
        // Write a program that finds the longest sequence of equal strings in the matrix. 

        string[,] theMatrix = new string[,]
        { 
        { "ha", "fifi", "ho", "hi" },
        { "fo", "ha", "hi", "xx" },
        { "xxx", "ho", "ha", "xx" }
        };

        string bestElement = theMatrix[0, 0];
        int checkSequence = 1;
        int maxSequence = 1;

        // checking all horizontal seqences
        for (int row = 0; row < theMatrix.GetLength(0); row++)
        {
            for (int column = 0; column < theMatrix.GetLength(1) - 1; column++)
            {
                if (theMatrix[row, column] == theMatrix[row, column + 1])
                {
                    checkSequence++;
                }
                else
                {
                    checkSequence = 1;
                }

                if (maxSequence < checkSequence)
                {
                    maxSequence = checkSequence;
                    bestElement = theMatrix[row, column];
                }
            }
            checkSequence = 1;
        }

        // checking all vertical sequenes
        for (int column = 0; column < theMatrix.GetLength(1); column++)
        {
            for (int row = 0; row < theMatrix.GetLength(0) - 1; row++)
            {
                if (theMatrix[row, column] == theMatrix[row + 1, column])
                {
                    checkSequence++;
                }
                else
                {
                    checkSequence = 1;
                }

                if (maxSequence < checkSequence)
                {
                    maxSequence = checkSequence;
                    bestElement = theMatrix[row, column];
                }
            }
            checkSequence = 1;
        }

        //checking all diagonals from top left to bottom right
        for (int i = 0; i < theMatrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < theMatrix.GetLength(1) - 1; j++)
            {
                for (int row = i, column = j; row < theMatrix.GetLength(0) - 1 && column < theMatrix.GetLength(1) - 1; row++, column++)
                {
                    if (theMatrix[row, column] == theMatrix[row + 1, column + 1])
                    {
                        checkSequence++;
                    }
                    else
                    {
                        checkSequence = 1;
                    }

                    if (maxSequence < checkSequence)
                    {
                        maxSequence = checkSequence;
                        bestElement = theMatrix[row, column];
                    }
                }
                checkSequence = 1;
            }
        }

        //checking all diagonals from top right to bottom left
        for (int i = 0; i < theMatrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < theMatrix.GetLength(1); j++)
            {
                for (int row = i, column = j; row < theMatrix.GetLength(0) - 1 && column > 0; row++, column--)
                {
                    if (theMatrix[row, column] == theMatrix[row + 1, column - 1])
                    {
                        checkSequence++;
                    }
                    else
                    {
                        checkSequence = 1;
                    }

                    if (maxSequence < checkSequence)
                    {
                        maxSequence = checkSequence;
                        bestElement = theMatrix[row, column];
                    }
                }
                checkSequence = 1;
            }
        }

        Console.Write("Equal string element: {0}, in sequence of {1} -> ", bestElement, maxSequence);

        for (int count = 1; count <= maxSequence; count++)
        {
            if (count < maxSequence)
            {
                Console.Write("{0}, ", bestElement);
            }
            else // count == maxSequence
            {
                Console.Write("{0}", bestElement);
            }
        }
        Console.WriteLine();
    }
}
