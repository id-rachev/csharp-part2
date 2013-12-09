using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class ReadMatrixWriteAreaSum
{
    static int[,] matrix;
    static int bestSum = int.MinValue;

    static void Main()
    {
        InputRead();

        ComputeResult();

        OutputWrite();
    }

    private static void OutputWrite()
    {
        StreamWriter textOutput = new StreamWriter("output.txt");
        using (textOutput)
        {
            textOutput.WriteLine(bestSum);
        }
    }

    private static void ComputeResult()
    {
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
        }
    }

    private static void InputRead()
    {
        StreamReader textInput = new StreamReader("input.txt");
        using (textInput)
        {
            string textLine = textInput.ReadLine();
            int matrixSize = int.Parse(textLine);
            matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                textLine = textInput.ReadLine();
                string[] numSequence = textLine.Split(' ');

                for (int column = 0; column < numSequence.Length; column++)
                {
                    matrix[row, column] = int.Parse(numSequence[column]);
                }
            }
        }
    }
}
