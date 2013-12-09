using System;

class MaxSumOfKElements
{
    static void Main()
    {
        //Write a program that reads two integer numbers:
        //N and K (K < N) and an array of N elements from the console.
        //Find in the array those K elements that have maximal sum.

        Console.Write("Enter first integer number (array length), N = ");
        int lengthArrN = int.Parse(Console.ReadLine());

        Console.Write("Enter second integer number (elements with max sum), K = ");
        int maxSumElementsK = int.Parse(Console.ReadLine());

        int[] userArray = new int[lengthArrN];

        for (int indexArr = 0; indexArr < lengthArrN; indexArr++)
        {
            Console.Write("Enter next array element: ");
            userArray[indexArr] = int.Parse(Console.ReadLine());
        }

        Array.Sort(userArray);

        for (int indexSum = lengthArrN - 1; indexSum >= lengthArrN - maxSumElementsK; indexSum--)
        {
            Console.Write(userArray[indexSum] + " ");

        }
        Console.WriteLine();
    }
}
