using System;

class MatrixFillsAndPrints
{
    static void Main()
    {
        // Write a program that fills and prints a matrix of size (n, n).

        // example a)

        Console.Write("Ener the side of the matrix, n = ");
        int rows = int.Parse(Console.ReadLine());

        int columns = rows;
        int element = 1;

        int[,] matrixA = new int[rows, columns];

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                matrixA[col, row] = element;
                element++;
            }
        }

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                Console.Write("{0:00} ", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        // example b)

        element = 1;

        for (int col = 0; col < columns; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrixA[row, col] = element++;
                }
            }
            else
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    matrixA[row, col] = element++;
                }
            }
        }

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                Console.Write("{0:00} ", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        // example c)

        element = 1;

        int currentRow = rows - 1;
        int currentCol = new int();
        int startRow = currentRow;
        int startCol = currentCol;
        while (element <= rows * columns)
        {
            while (currentCol < columns && currentRow < rows)
            {
                matrixA[currentRow, currentCol] = element;
                element++;
                currentRow++;
                currentCol++;
            }

            if (startRow == 0)
            {
                startCol++;
            }
            else
            {
                startRow--;
            }
            currentCol = startCol;
            currentRow = startRow;
        }

        for (int row = 0; row < matrixA.GetLength(0); row++)
        {
            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                Console.Write("{0:00} ", matrixA[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
