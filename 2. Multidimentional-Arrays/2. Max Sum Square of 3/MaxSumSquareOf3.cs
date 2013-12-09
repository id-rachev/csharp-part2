using System;
using System.Linq;

class MaxSumSquareOf3
{
    static void Main()
    {
        // Write a program that reads a rectangular matrix of size N x M
        // and finds in it the square 3 x 3 that has maximal sum of its elements.

        Console.Write("Enter number of rows for matrix, N = ");
        int rowsN = int.Parse(Console.ReadLine());
    
        Console.Write("Enter number of columns for matrix, M = ");
        int columnsM = int.Parse(Console.ReadLine());

        int[,] userArray = new int[rowsN, columnsM];
        for (int row = 0; row < userArray.GetLength(0); row++)
        {
            for (int col = 0; col < userArray.GetLength(1); col++)
            {
                Console.Write("Enter next matrix element for row {0}, column {1}: ", row, col);
                userArray[row, col] = int.Parse(Console.ReadLine());
            }
        }
        
        int sum = new int();
        int maxSum = int.MinValue;
        int startRowMaxSum = new int();
        int startColMaxSum = new int();

        for (int row = 0; row < rowsN - 2; row++)
        {
            for (int col = 0; col < columnsM - 2; col++)
            {
                sum += userArray[row, col] + userArray[row, col + 1] + userArray[row, col + 2] +
                    userArray[row + 1, col] + userArray[row + 1, col + 1] + userArray[row + 1, col + 2] +
                    userArray[row + 2, col] + userArray[row + 2, col + 1] + userArray[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    startRowMaxSum = row;
                    startColMaxSum = col;
                }
                sum = 0;
            }
        }
        Console.WriteLine(maxSum);

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write("{0:00} ", userArray[startRowMaxSum, startColMaxSum]);
                startColMaxSum++;
            }

            startColMaxSum = startColMaxSum - 3;
            startRowMaxSum++;
            Console.WriteLine();
        }
    }
}
